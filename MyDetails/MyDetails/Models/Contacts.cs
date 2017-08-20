using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyDetails.Models
{
    public class Contacts
    {
        public string name,
                      company,
                      designation,
                      address,
                      email,
                      telephone;

        public void setName(string Name)
        {
            this.name = Name;
        }
        public string getName()
        {
            return name;
        }

        public void setCompany(string Company)
        {
            this.company = Company;
        }
        public string getCompany()
        {
            return company;
        }

        public void setDesignation(string ds)
        {
            this.designation = ds;
        }
        public string getDesig()
        {
            return designation;
        }

        public void setAddress(string add)
        {
            this.address = add;
        }
        public string getAddress()
        {
            return address;
        }

        public void setPhone(string phone)
        {
            this.telephone = phone;
        }
        public string getPhone()
        {
            return telephone;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getEmail()
        {
            return email;
        }

    }
}