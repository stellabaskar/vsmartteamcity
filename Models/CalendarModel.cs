using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC5RealWorld.Models
{
    public class CalendarModel
    {
    }
    public class CalendarContext : DbContext
    {
        public CalendarContext()
            : base("CalendarDB")
        {
        }

        public DbSet<dotmailer_project_view> dotmailer_project_view { get; set; }
        //public DbSet<Calendar_Date_Description> calendar_Date_Descriptions { get; set; }
        //public DbSet<Calendar_Date_Holiday> calendar_Date_Holiday { get; set; }
        //public DbSet<Calendar_Date_Image> calendar_Date_Image { get; set; }
        //public DbSet<Calendar_Dates> calendar_Dates { get; set; }
        //public DbSet<Calendar_Dictionary> calendar_Dictionary { get; set; }
        //public DbSet<Calendar_Dictionary_Categories> calendar_Dictionary_Categories { get; set; }
        //public DbSet<Calendar_Holidays> calendar_Holidays { get; set; }
        //public DbSet<Calendar_Image_Categories> calendar_Image_Categories { get; set; }
        //public DbSet<Calendar_Images> calendar_Images { get; set; }
        //public DbSet<Calendar_User_Data> calendar_User_Data { get; set; }


    }


    [Table("dotmailer_project_view")]
    public class dotmailer_project_view
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]

        
        public System.Int32 Project_Database_ID { get; set; }
        public string Project_Name { get; set; }
        public string Project_Number { get; set; }
        public System.Int32 Person_Database_ID { get; set; }
        public string Person_FirstName { get; set; }
        public string Person_LastName { get; set; }
        public string Person_Email { get; set; }
        public System.Int32 Company_Database_ID { get; set; }
        public string Company_Name { get; set; }
    }
        

    

    public class ManageDatabaseViewModel
    {
        public List<string> Tables = new List<string>();

    }
  
}

    //[Table("calendar_date_holiday")]
    //public class Calendar_Date_Holiday
    //{
    //    [Key]
    //    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
    //    public int id { get; set; }
    //    public int date_id { get; set; }
    //    public int user_id { get; set; }
    //    public int holiday_id { get; set; }
    //}
    //[Table("calendar_date_image")]
    //public class Calendar_Date_Image
    //{
    //    [Key]
    //    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
    //    public int id { get; set; }
    //    public int date_id { get; set; }
    //    public int image_id { get; set; }
    //    public int user_id { get; set; }
    //    public int slot_id { get; set; }
    //}
    //[Table("calendar_dates")]
    //public class Calendar_Dates
    //{
    //    [Key]
    //    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
    //    public int id { get; set; }
    //    public int day { get; set; }
    //    public int month { get; set; }
    //    public int year { get; set; }
    //    public string name_day { get; set; }
    //    public string red_day { get; set; }
    //}
    //[Table("calendar_user_data")]
    //public class Calendar_User_Data
    //{
    //    [Key]
    //    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
    //    public int id { get; set; }
    //    public int userid { get; set; }
    //    public int year { get; set; }
    //    public int day { get; set; }
    //    public int month { get; set; }
    //    public string Images { get; set; }
    //    public string Holidays { get; set; }
    //    public string TextArea { get; set; }
    //    public string date { get; set; }
    //    public string data { get; set; }
    //    public string licenseId { get; set; }
    //}
    //[Table("calendar_dictionary")]
    //public class Calendar_Dictionary
    //{
    //    [Key]
    //    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
    //    public int id { get; set; }
    //    public string name { get; set; }
    //    public string description { get; set; }
    //    public int dictionary_category_id { get; set; }
    //}
    //[Table("calendar_dictionary_categories")]
    //public class Calendar_Dictionary_Categories
    //{
    //    [Key]
    //    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
    //    public int id { get; set; }
    //    public string name { get; set; }
    //}
    //[Table("calendar_holidays")]
    //public class Calendar_Holidays
    //{
    //    [Key]
    //    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
    //    public int id { get; set; }
    //    public int month { get; set; }
    //    public int year { get; set; }
    //    public string name { get; set; }
    //    public int flag_day { get; set; }
    //    public int image_icon { get; set; }
    //    public int red_days { get; set; }
    //    public int userid { get; set; }
    //    public string description { get; set; }      

    //}
    //[Table("calendar_image_categories")]
    //public class Calendar_Image_Categories
    //{
    //    [Key]
    //    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
    //    public int id { get; set; }
    //    public string name { get; set; }
    //    public string description { get; set; }
    //}
    //[Table("calendar_images")]
    //public class Calendar_Images
    //{
    //    [Key]
    //    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
    //    public int id { get; set; }
    //    public string url { get; set; }
    //    public string description { get; set; }
    //    public int category_id { get; set; }
    //    public int is_public { get; set; }
    //    public string licence_id { get; set; }
    //    public int userid { get; set; }
    //    public bool isActive { get; set; }
    //}
    ////[Table("calendar_user_images")]
    ////public class Calendar_User_Images
    ////{
    ////    [Key]
    ////    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
    ////    public int id { get; set; }
    ////    public string url { get; set; }
    ////    public string description { get; set; }
    ////    //public int category_id { get; set; }
    ////    public int userid { get; set; }
    ////}
    //[Table("calendar_users")]
    //public class Calendar_Users
    //{
    //    [Key]
    //    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
    //    public int id { get; set; }
    //    public string name { get; set; }
    //    public string username { get; set; }
    //    public string password { get; set; }
    //    public string email { get; set; }
    //}
    