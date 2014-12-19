using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Hosting;

namespace WcfDemo.Service
{
    public class Service : IService
    {
        private string path = HostingEnvironment.MapPath("/App_Data/contacts.json");
        private List<Contact> contacts;

        public Service()
        {
            this.Retrieve();
        }

        public Contact Select(Guid id)
        {
            return contacts.SingleOrDefault(c => c.Id == id);
        }

        public IEnumerable<Contact> All()
        {
            return contacts;
        }

        public void Save(Contact contact)
        {
            if (contact.Id == Guid.Empty)
            {
                contact.Id = Guid.NewGuid();
                contacts.Add(contact);
            }
            else
            {
                int i = contacts.FindIndex(c => c.Id == contact.Id);
                contacts[i] = contact;
            }

            this.Commit();
        }

        public void Remove(Contact contact)
        {
            // does not work because comparison is made on object reference
            //contacts.Remove(contact);

            var _contact = contacts.SingleOrDefault(c => c.Id == contact.Id);
            contacts.Remove(_contact);

            this.Commit();
        }

        private void Retrieve()
        {
            string json = System.IO.File.ReadAllText(path, Encoding.UTF8);
            contacts = JsonConvert.DeserializeObject<List<Contact>>(json) ?? new List<Contact>();
        }

        private void Commit()
        {
            string json = JsonConvert.SerializeObject(contacts.ToArray(), Formatting.Indented);
            System.IO.File.WriteAllText(path, json, Encoding.UTF8);
        }
    }
}
