using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Xml.Serialization;


namespace Serialize.Models
{


    [Serializable]
    public class Program
    {
        [Display(Name = "Debtor")]
        public string Debtor { get; set; }
        [Display(Name = "Debtor Ssn")]
        public string DebtorSsn { get; set; }
        [Display(Name = "Debtor Address")]
        public string DebtorAddress1 { get; set; }
        [Display(Name = "Debtor Address2")]
        public string DebtorAddress2 { get; set; }
        [Display(Name = "Debtor Address3")]
        public string DebtorAddress3 { get; set; }
        [Display(Name = "Debtor County")]
        public string DebtorCounty { get; set; }
        [Display(Name = "Debtor Email")]
        public string DebtorEmail { get; set; }
        [Display(Name = "Debtor DOB")]
        public string DateOfBirth { get; set; }
        [Display(Name = "Debtor Ph. Number")]
        public string DebtorCellPhone { get; set; }
        [Display(Name = "Spouse")]
        public string Spouse { get; set; }
        [Display(Name = "Spouse Ssn")]
        public string SpouseSsn { get; set; }
        [Display(Name = "Spouse Address 1")]
        public string SpouseAddress1 { get; set; }
        [Display(Name = "Spouse Address 2")]
        public string SpouseAddress2 { get; set; }
        [Display(Name = "Spouse Address 3")]
        public string SpouseAddress3 { get; set; }
        [Display(Name = "Spouse County")]
        public string SpouseCounty { get; set; }
        [Display(Name = "Spouse Email")]
        public string SpouseEmail { get; set; }
        [Display(Name = "Spouse DOB")]
        public string SpouseDateOfBirth { get; set; }
        [Display(Name = "Spouse Ph. Num.")]
        public string SpouseCellPhone { get; set; }
        [Display(Name = "Attorney Ch.")]
        public string Chapter { get; set; }
        [Display(Name = "Debtor Type")]
        public string TypeofDebtor { get; set; }
        [Display(Name = "Attorney Bar")]
        public string BarId { get; set; }
        [Display(Name = "Active?")]
        public string IsActive { get; set; }

        
        
        
        
        
        
        
        
        
        private void DeserializeObject(string filename)
        {
            Console.WriteLine("Reading with XmlReader");

            //Create an instance of XmlSerializer specifying type
            XmlSerializer serializer = new XmlSerializer(typeof(Program));

            // To read our XML Document
            StreamReader fileStream = new StreamReader(filename);


            //Declare our object of the type to deserialize
            Program debtor = (Program) serializer.Deserialize(fileStream);
            fileStream.Close();




            //Write out our properties
            Console.Write(
                debtor.Debtor + "\t" +
                debtor.DebtorSsn + "\t" +
                debtor.DebtorAddress1 + "\t" +
                debtor.DebtorAddress2 + "\t" +
                debtor.DebtorAddress3 + "\t" +
                debtor.DebtorCounty + "\t" +
                debtor.DebtorEmail + "\t" +
                debtor.DateOfBirth + "\t" +
                debtor.DebtorCellPhone + "\t" +
                debtor.Spouse + "\t" +
                debtor.SpouseSsn + "\t" +
                debtor.SpouseAddress1 + "\t" +
                debtor.SpouseAddress2 + "\t" +
                debtor.SpouseAddress3 + "\t" +
                debtor.SpouseCounty + "\t" +
                debtor.SpouseEmail + "\t" +
                debtor.SpouseDateOfBirth + "\t" +
                debtor.SpouseCellPhone + "\t" +
                debtor.Chapter + "\t" +
                debtor.TypeofDebtor + "\t" +
                debtor.BarId + "\t" +
                debtor.IsActive
            );

        }

        public static void Main(string[] args)
        {
            Program app = new Program();
            app.DeserializeObject("~\\Content\\files\\form.xml");
        }
    }






} 
    
    
    
    
    
    
