using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppCF.Models;

namespace WinAppCF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] ms = new int[] { 345, 345, 23, 34, 6346, 34, 4 };

            List<int> ls = new List<int>(ms);

           var resultim = ls.Where(x => x > 300000);

            ls.Add(4000000);
            ls.Add(3500000);

           int[] rf = resultim.ToArray();



            //var rs = from f in ms
            //         where f > 200
            //         select f;

            //var rsCompact = ms.Where(x => x > 200).Select(x=>x);


            //using (PeopleDbContext c = new PeopleDbContext())
            //{
            //    Person person = new Person
            //    {
            //        Email = "person@gmail.com",
            //        Name = "Person Name"
            //    };
            //    c.People.Add(person);

            //    c.Passports.Add(new Passport
            //    {
            //        ExpireDate = DateTime.Now.AddYears(3),
            //        GivenDate = DateTime.Now,
            //        GivenOrg = "QWERTY MMC",
            //        Number = "AZE23423423",
            //        Person = person
            //    });
            //    c.SaveChanges();
            //}

            Person person = null;
            using (PeopleDbContext p = new PeopleDbContext())
            {

                p.Database.Log = (str) => richTextBox1.Text += str;
                // person = p.People.ToList().Where(x => x.Email == "fake1@ff.com").FirstOrDefault();

                //var result = (from c in p.People
                //              where c.Email == "fake@ff.com"
                //              select c).Where(x => x.Id > 4);

                var anonymous = (from ps in p.Passports
                             join pp in p.People
                             on ps.PersonId equals pp.Id
                             select new
                             {
                                 ps.Number,
                                 ps.GivenDate,
                                 ps.GivenOrg,
                                 pp.Name,
                                 pp.Email
                             });

                //p.Passports.Join()

                foreach (var item in anonymous)
                {
                    int f = 89;
                }


                //person.Email = "fake1@ff.com";

                // p.Entry(person).State = EntityState.Deleted;

                //person.Email = "fake@fake.com";

                // p.People.Update(p,person);
                // p.People.Remove(person);
               // p.SaveChanges();
            }

           



        }
    }
}
