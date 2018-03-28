using MVC5RealWorld.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Mvc;
using System.Text;




namespace MVC5RealWorld.Controllers
{
    public class AdminController : Controller
    {
        private CalendarContext db = new CalendarContext();
        public class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public List<Address> Addresses { get; set; }
        }

        public class Address
        {
            public string Line1 { get; set; }
            public string Line2 { get; set; }
            public string ZipCode { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Country { get; set; }
        }

        public class Student
        {
            public string Pname { get; set; }
            //public string LastName { get; set; }
            //public string Class { get; set; }
               }                           


        // GET: /Admin/
        public ActionResult Login()
        {
            //var dotmailer_record_data = from m in db.dotmailer_project_view
            // select m.Project_Name;
            //  return View(db.dotmailer_project_view.ToList().Take(10).ToList());
            //return (dotmailer_record_data.ToList());
            //////////// String connectionString = "Data Source=212.214.255.146;Initial Catalog=SuperOffice8;User ID=superoffice_reader;Password=i_is#_Da$upReadah-one1!";
            //////////// //String sql = "SELECT top 10 Project_Name FROM dotmailer_project_view";
            //////////// //String sql = "SELECT Project_Name FROM dotmailer_project_view where Project_Name like '%testbooks%' group by project_name";

            //////////// String sql = "SELECT Project_Name, Person_Email FROM dotmailer_project_view where Project_Name = 'TestBookSale_Kiruna_2018'";


            //////////// SqlConnection conn = new SqlConnection(connectionString);
            //////////// SqlCommand cmd = new SqlCommand(sql, conn);

            //////////// var model1 = new List<Student>();
            //////////// var student = new Student();
            //////////// student.Pname = "SELECT";
            ////////////// model1.Add(student);
            //////////// using (conn)
            //////////// {
            ////////////     conn.Open();
            ////////////     SqlDataReader rdr = cmd.ExecuteReader();
            ////////////     while (rdr.Read())
            ////////////     {

            ////////////         student.Pname = rdr[0].ToString();                 


            ////////////         model1.Add(student);
            ////////////     }

            //////////// }

            //var model1 = new List<Student>();
            //var student = new Student();


            //student.Pname = "Select";
            //model1.Add(student);
            //student.Pname = "Stella";
            //model1.Add(student);
            //student.Pname = "Ragu";
            //model1.Add(student);

            List<string> model1 = new List<string>();
            model1.Add("--Select--");
          
           


            ViewBag.MyList = model1.ToList();
            ViewBag.MyList  = model1.Select(x => new SelectListItem { Text = x.ToString() }).ToList();

            return View();

            //return View();

            //ViewData["Data"] = objSt;
            //return View();

            //var totalcount = dotmailer_record_data.ToList().Count;


            //UserDetails objuser = new UserDetails();
            //var result = new List<QueryResult>();

            //List<UserDetails> userlist = new List<UserDetails>();
            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{
            //UserDetails uobj = new UserDetails();
            //uobj.UserId = Convert.ToInt32(ds.Tables[0].Rows[i]["userid"].ToString());
            //uobj.UserName = ds.Tables[0].Rows[i]["username"].ToString();
            //uobj.Education = ds.Tables[0].Rows[i]["education"].ToString();
            //uobj.Location = ds.Tables[0].Rows[i]["location"].ToString();
            //userlist.Add(uobj);
            //}
            //objuser.usersinfo = userlist;

            //return View(objuser);



            // ViewBag.countrydrop = db.dotmailer_project_view.Select(x => new SelectListItem { Text = x.Project_Name.ToString() }).ToList();

            ////////foreach (var item in db.dotmailer_project_view.ToList())

            ////////{



            ////////    var pname = item.Person_FirstName;
            ////////    var mailid = item.Person_Email;
            ////////    var projname = item.Project_Name;



            ////////    // var url = "/v2/data-fields";
            ////////    //var content = @"{ email: ""john.smith@example.com"", optInType: ""Single"", emailType: ""Html"", dataFields: [ { key: ""FIRSTNAME"", value: ""John"" }, { key: ""FULLNAME"", value: ""John Smith"" }, { key: ""GENDER"", value: ""Male"" }, { key: ""LASTNAME"", value: ""Smith"" }, { key: ""POSTCODE"", value: ""N5 1DP"" } ] }";
            ////////    //using (var httpClient = new HttpClient())
            ////////    // {
            ////////    //httpClient.BaseAddress = new Uri("https://r1-api.dotmailer.com");
            ////////    //var credentials = Encoding.ASCII.GetBytes("apiuser-b7e9b94da67a@apiconnector.com:stellabaskar123");
            ////////    //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(credentials));
            ////////    //var result = httpClient.PostAsync(url, new StringContent(content, Encoding.UTF8, "application/json")).Result;

            ////////    // httpClient.BaseAddress = new Uri("https://api.dotmailer.com");
            ////////    //var credentials = Encoding.ASCII.GetBytes("username:password");
            ////////    //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(credentials));

            ////////    // var result = httpClient.GetAsync(url).Result;

            ////////    //var url = "/v2/address-books/1/contacts";
            ////////    //var content = @"{ email: ""john.smith@example.com"", optInType: ""Single"", emailType: ""Html"", dataFields: [ { key: ""FIRSTNAME"", value: ""John"" }, { key: ""FULLNAME"", value: ""John Smith"" }, { key: ""GENDER"", value: ""Male"" }, { key: ""LASTNAME"", value: ""Smith"" }, { key: ""POSTCODE"", value: ""N5 1DP"" } ] }";
            ////////    //using (var httpClient = new HttpClient())
            ////////    //{
            ////////    //httpClient.BaseAddress = new Uri("https://r1-api.dotmailer.com");
            ////////    //var credentials = Encoding.ASCII.GetBytes("apiuser-b7e9b94da67a@apiconnector.com:stellabaskar123");
            ////////    //    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(credentials));
            ////////    //    var result = httpClient.PostAsync(url, new StringContent(content, Encoding.UTF8, "application/json")).Result;
            ////////    //}

            ////////    // }
            ////////    //  var url = "/v2/address-books";
            ////////    // var content = @"{ name: ""My Address Book"", visibility: ""Public"" }";

            ////////    //var url = "/v2/address-books/My Address Book/contacts";
            ////////    //var url = "/v2/contacts/200";

            ////////    ////"{ email: \"stellababy@gmail.com\", emailType: \"Html\", dataFields: [ { key: \"FIRSTNAME\", value: \"John\" }, { key: \"FULLNAME\", value: \"John Smith\" }, { key: \"GENDER\", value: \"Male\" }, { key: \"LASTNAME\", value: \"Smith\" }, { key: \"POSTCODE\", value: \"N5 1DP\" } ] }"

            ////////    //// var content = @"{ email: ""stellababy@gmail.com"", emailType: ""Html"", dataFields: [ { key: ""FIRSTNAME"", value: ""John"" }, { key: ""FULLNAME"", value: ""John Smith"" }, { key: ""GENDER"", value: ""Male"" }, { key: ""LASTNAME"", value: ""Smith"" }, { key: ""POSTCODE"", value: ""N5 1DP"" } ] }";

            ////////    //var content = "{ email: \"" + mailid + "\"" + ", emailType: \"Html\", dataFields: [ { key: \"PERSON_NAME\", value: \"" + pname + "\" },{ key: \"SO_EMAILID\", value: \"" + mailid + "\" }, { key: \"SO_PROJECT_NAME\", value: \"" + projname + "\" } ] }";







            ////////    //using (var httpClient = new HttpClient())
            ////////    //{
            ////////    //    httpClient.BaseAddress = new Uri("https://r1-api.dotmailer.com");
            ////////    //    var credentials = Encoding.ASCII.GetBytes("apiuser-b7e9b94da67a@apiconnector.com:stellabaskar123");
            ////////    //    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(credentials));
            ////////    //    var result = httpClient.PostAsync(url, new StringContent(content, Encoding.UTF8, "application/json")).Result;
            ////////    //}
            ////////    // var url = "/v2/contacts/100/";
            ////////    //var content2 = @"{ email: ""john.smith@example.com"", optInType: ""Double"", dataFields: [ { key: ""GENDER"", value: ""Male"" } ] }";
            ////////    //using (var httpClient = new HttpClient())
            ////////    //{
            ////////    //    httpClient.BaseAddress = new Uri("https://r1-api.dotmailer.com");
            ////////    //    //apiuser-17d45b19fb3a@apiconnector.com:vsmart123
            ////////    //    //var credentials = Encoding.ASCII.GetBytes("apiuser-b7e9b94da67a@apiconnector.com:stellabaskar123");


            ////////    //    var credentials = Encoding.ASCII.GetBytes("apiuser-17d45b19fb3a@apiconnector.com:vsmart123");
            ////////    //    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(credentials));
            ////////    //    var result = httpClient.PutAsync(url, new StringContent(content, Encoding.UTF8, "application/json")).Result;
            ////////    //}
            ////////    //var url1 = "/v2/email";
            ////////    //var content1 = @"{ toAddresses: [""stellabaskar@gmail.com""], subject: ""Your order has dispatched"", fromAddress: ""Stella-test1-dotmailer@mycompany.com"", htmlContent: """", plainTextContent: ""Hi. This is to let you know that your order has now been dispatched. Thank you for business."" }";
            ////////    //using (var httpClient = new HttpClient())
            ////////    //{
            ////////    //    httpClient.BaseAddress = new Uri("https://r1-api.dotmailer.com");
            ////////    //    var credentials = Encoding.ASCII.GetBytes("apiuser-b7e9b94da67a@apiconnector.com:stellabaskar123");
            ////////    //    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(credentials));
            ////////    //    var result = httpClient.PostAsync(url1, new StringContent(content1, Encoding.UTF8, "application/json")).Result;
            ////////    //}


            ////////    //using (var httpClient = new HttpClient())
            ////////    //{
            ////////    //    // httpClient.BaseAddress = new Uri("https://api.dotmailer.com");
            ////////    //    // var credentials = Encoding.ASCII.GetBytes("username:password");
            ////////    //    httpClient.BaseAddress = new Uri("https://r1-api.dotmailer.com");
            ////////    //    var credentials = Encoding.ASCII.GetBytes("apiuser-b7e9b94da67a@apiconnector.com:stellabaskar123");

            ////////    //    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(credentials));
            ////////    //    var result = httpClient.PostAsync(url, new StringContent(content, Encoding.UTF8, "application/json")).Result;
            ////////    //}
            ////////}
           // return View();

        }


        //{
        //    //List<City> objcity = new List<City>();

        //    //SelectList obgcity = new SelectList(objcity, "Id", "CityName", 0);

        //    ViewBag.countrydrop1 = db.dotmailer_record.ToList().Where(m => m.project_name == projname).ToList();

        //    return Viewdata((db.dotmailer_record.ToList().Where(m => m.project_name == projname)).ToList());
        //}


        //[HttpPost]
        //public ActionResult GetCityByStaeId(string projname)
        //{
        //    //List<City> objcity = new List<City>();

        //    //SelectList obgcity = new SelectList(objcity, "Id", "CityName", 0);

        //    ViewBag.countrydrop1 = db.dotmailer_record.ToList().Where(m => m.project_name == projname).ToList();

        //    return Viewdata((db.dotmailer_record.ToList().Where(m => m.project_name == projname)).ToList());
        //}
        [HttpPost]
        public JsonResult StateList(string projname)
        {

            //string str = @"Data Source=DEV_3\SQLEXPRESS;Initial Catalog=DB_Naved_Test;Integrated Security=True";
            //SqlConnection con = new SqlConnection(str);
            //string query = "select * from tbl_states where cid='" + Id + "'";
            //SqlCommand cmd = new SqlCommand(query, con);
            //con.Open();
            //SqlDataReader rdr = cmd.ExecuteReader();

           // var dotmailer_record_data1 = from m in db.dotmailer_record
                                        //where m.project_name == projname
                                        //select m;

            //List<SelectListItem> li = new List<SelectListItem>();
            //while (rdr.Read())
            //{
            //    li.Add(new SelectListItem { Text = rdr[1].ToString(), Value = rdr[0].ToString() });
            //}
            // return View(dotmailer_record_data.ToList());

            //ViewBag.countrydrop1 = dotmailer_record_data1.Select(x => new SelectListItem { Text = x.person_Email.ToString() }).ToList();
            //
            // var test = "stella";
            //return Json(test, JsonRequestBehavior.AllowGet);
            //            return Json(dotmailer_record_data1.ToList(), JsonRequestBehavior.AllowGet);

            //string str = @"Data Source=tcp:majema-db-server-test.database.windows.net,1433;Initial Catalog=dotmailer_test_platform;User ID=majema_stockholm_test;Password=mlohkcotS_sucraM";
            string str = "Data Source = 212.214.255.146; Initial Catalog = SuperOffice8; User ID = superoffice_reader; Password = i_is#_Da$upReadah-one1!";
            SqlConnection con = new SqlConnection(str);
            string query = "select person_Email from dotmailer_project_view where project_name='" + projname + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            List<SelectListItem> li = new List<SelectListItem>();
            while (rdr.Read())
            {
                li.Add(new SelectListItem { Text = rdr[0].ToString() });
            }
            return Json(li, JsonRequestBehavior.AllowGet);


        }

        //[HttpPost]
        //public JsonResult PostMethod(string name)
        //{
        //    //List<string> lstTest = new List<string>();


        //    var dotmailer_record_data1 = from m in db.dotmailer_record
        //                                 where m.project_name == name
        //                                 select m;

        //    PersonModel person = new PersonModel
        //    {
        //       // mailList.AddRange(dotmailer_record_data1.toList());
        //       //mailList.
        //  // mailList.AddRange(lstTest);
        //    Name = name,
        //    //DateTime = DateTime.Now.ToString()
        //};
        //    return Json(person);
        //    //return (lstTest);
        //}
        ////[HttpPost]
        //public JsonResult GetJsonData()
        //{
        //    var persons = new List<Person>
        //                      {
        //                          new Person{Id = 1, FirstName = "F1",
        //                              LastName = "L1",
        //                              Addresses = new List<Address>
        //                                              {
        //                                                  new Address{Line1 = "LaneA"},
        //                                                  new Address{Line1 = "LaneB"}
        //                                              }},

        //                          new Person{Id = 2, FirstName = "F2",
        //                              LastName = "L2",
        //                              Addresses = new List<Address>
        //                                              {
        //                                                  new Address{Line1 = "LaneC"},
        //                                                  new Address{Line1 = "LaneD"}
        //                                              }}};

        //    return Json(persons, JsonRequestBehavior.AllowGet);
        //}
        ////////////[HttpPost]
        //////////public JsonResult UpdateField(int id, string fieldName, string fieldValue)
        //////////{
        //////////   var  entity = db.calendar_Images.First(e => e.id == id);
        //////////    if (entity == null) return Json(new { success = false });
        //////////    //this line must to be improved
        //////////    // fieldValue parameter should be an object, not an string
        //////////    // , it should infer field type and instance a new object of field type with fieldValue
        //////////    entity.GetType().GetProperty(fieldName).SetValue(entity, fieldValue);
        //////////    db.Entry(entity).State = EntityState.Modified;
        //////////    db.SaveChanges();

        //////////    return Json(new { success = true });
        //////////}     
        //////////// GET: /Admin/Details/5
        ////////public ActionResult Details(int? id)
        ////////{
        ////////    if (project_name.ToString() == null)
        ////////    {
        ////////        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        ////////    }
        ////////    dotmailer_record dotmailer_record = db.dotmailer_record.Find(project_name);
        ////////    if (dotmailer_record == null)
        ////////    {
        ////////        return HttpNotFound();
        ////////    }
        ////////    return View(dotmailer_record);
        ////////}
        // GET: /Admin/Details/5

        [HttpPost]
        public JsonResult SendMail(string projname)
        {

            //string str = @"Data Source=DEV_3\SQLEXPRESS;Initial Catalog=DB_Naved_Test;Integrated Security=True";
            //SqlConnection con = new SqlConnection(str);
            //string query = "select * from tbl_states where cid='" + Id + "'";
            //SqlCommand cmd = new SqlCommand(query, con);
            //con.Open();
            //SqlDataReader rdr = cmd.ExecuteReader();

            // var dotmailer_record_data1 = from m in db.dotmailer_record
            //where m.project_name == projname
            //select m;

            //List<SelectListItem> li = new List<SelectListItem>();
            //while (rdr.Read())
            //{
            //    li.Add(new SelectListItem { Text = rdr[1].ToString(), Value = rdr[0].ToString() });
            //}
            // return View(dotmailer_record_data.ToList());

            //ViewBag.countrydrop1 = dotmailer_record_data1.Select(x => new SelectListItem { Text = x.person_Email.ToString() }).ToList();
            //
            // var test = "stella";
            //return Json(test, JsonRequestBehavior.AllowGet);
            //            return Json(dotmailer_record_data1.ToList(), JsonRequestBehavior.AllowGet);

            //string str = @"Data Source=tcp:majema-db-server-test.database.windows.net,1433;Initial Catalog=dotmailer_test_platform;User ID=majema_stockholm_test;Password=mlohkcotS_sucraM";
            string str = "Data Source = 212.214.255.146; Initial Catalog = SuperOffice8; User ID = superoffice_reader; Password = i_is#_Da$upReadah-one1!";

            SqlConnection con = new SqlConnection(str);
            string query = "select person_Email from dotmailer_project_view where project_name='" + projname + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            List<SelectListItem> li = new List<SelectListItem>();
            while (rdr.Read())

            {
                li.Add(new SelectListItem { Text = rdr[0].ToString() });

                var url1 = "/v2/email/triggered-campaign";

                //var url = "/v2/email";
                 var content1 = "{ toAddresses: [\"" + rdr[0].ToString() + "\"]" + " , campaignId: 369016, personalizationValues: []}";
                //var content1 = @"{ toAddresses: [""production@vsmarttec.com""] , campaignId: 369016, personalizationValues: []}";
                //var content1 = @"{ toAddresses: [""production@vsmarttec.com""] , campaignId: 369016, personalizationValues: [{ Name: ""FIRSTNAME"" , Value: ""John"" }]}";

                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri("https://r1-api.dotmailer.com");
                    //var credentials = Encoding.ASCII.GetBytes("transactionalemail-fd0ea22a57f0@apiconnector.com:stellababy123");
                    var credentials = Encoding.ASCII.GetBytes("apiuser-9c5b9e680cf3@apiconnector.com:stellababy123");
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(credentials));
                    var result = httpClient.PostAsync(url1, new StringContent(content1, Encoding.UTF8, "application/json")).Result;
                }


                //correct var content1 = "{ toAddresses: [\"" + rdr[0].ToString() + "\"]" + " , campaignId: 358837, personalizationValues: [{ Name: ""FIRSTNAME"" , Value: ""John"" }]}";
                //correct var content = "{ toAddresses: [\"" + rdr[0].ToString() + "\"]" + " , subject: \"This is testmail from Stella!!\", fromAddress: \"Stella-test1-dotmailer@mycompany.com\", htmlContent: \"\", plainTextContent: \"Hi. This is to let you know that your order has now been dispatched. Thank you for business.\" }";

                //358288
                //var content1 = "{ toAddresses: [\"" + rdr[0].ToString() + "\"]" + ", CompaignId:5612 , subject: \"This is testmail from Stella!!\", fromAddress: \"Stella-test1-dotmailer@mycompany.com\", htmlContent: \"\", plainTextContent: \"Hi. This is to let you know that your order has now been dispatched. Thank you for business.\" }";
                //var content = "{ toAddresses: \"" + "production@vsmarttec.com" + "\"" + ", subject: \"Your order has dispatched\", fromAddress: \"Stella-test1-dotmailer@mycompany.com\", htmlContent: \"\", plainTextContent: \"Hi. This is to let you know that your order has now been dispatched. Thank you for business.\" }";

                // var content = "{ toAddresses: [\"" + rdr[0].ToString() + "\"]" + " , subject: \"This is testmail from Stella!!\", fromAddress: \"Stella-test1-dotmailer@mycompany.com\", htmlContent: \"\", plainTextContent: \"Hi. This is to let you know that your order has now been dispatched. Thank you for business.\" }";
                //var content1 = @"{ toAddresses: [""stellabaskar@gmail.com""], campaignId: ""358288"", personalizationValues:  [{ Name: ""FIRSTNAME"" , Value: ""John"" } ] }";

                //var content = "{ toAddresses: [\"" + rdr[0].ToString() + "\"]" + " , subject: \"This is testmail from Stella!!\", fromAddress: \"Stella-test1-dotmailer@mycompany.com\", htmlContent: \"\", plainTextContent: \"Hi. This is to let you know that your order has now been dispatched. Thank you for business.\" }";



                //var content1 = @"{ toAddresses: [""stellabaskar@gmail.com""] , campaignId: 360124, personalizationValues: [{ Name: ""PFNAME"" , Value: ""Stella"" }, { Name: ""PROJECTNAME"" , Value: ""EVENT1"" } ] }";


                //correct var content = "{ toAddresses: [\"" + rdr[0].ToString() + "\"]" + " , subject: \"This is testmail from Stella!!\", fromAddress: \"Stella-test1-dotmailer@mycompany.com\", htmlContent: \"\", plainTextContent: \"Hi. This is to let you know that your order has now been dispatched. Thank you for business.\" }";
                //var content1 = "{ toAddresses: [\"" + rdr[0].ToString() + "\"]" + " , campaignId: 360123, personalizationValues: [{ Name: ""FIRSTNAME"" , Value: ""Stella"" }, { Name: ""PROJECTNAME"" , Value: ""EVENT1"" }, { Name: ""PFNAME"" , Value: ""STELLA"" },{ Name: ""PLNAME"" , Value: ""BASKAR"" },{ Name: ""PEMAIL"" , Value: ""STELLABASKAR@GMAIL.COM"" },{ Name: ""COMPANY"" , Value: ""VSMART"" }]}";

                ////////////correctvar content1 = "{ toAddresses: [\"" + rdr[0].ToString() + "\"]" + " , campaignId: 362486, personalizationValues: [{ Name: \"PFNAME\" , Value: \"" + rdr[1].ToString() + "\" }, { Name: \"PROJECTNAME\" , Value: \"" + rdr[2].ToString() + "\" }]}";



                //360123
                //358837-S1


                //var content = @"{ toAddresses: [""stellabaskar@gmail.com""], subject: ""Your order has dispatched"", fromAddress: ""orders@mycompany.com"", htmlContent: """", plainTextContent: ""Hi. This is to let you know that your order has now been dispatched. Thank you for business."" }";
                //////////////using (var httpClient = new HttpClient())
                //////////////{
                //////////////    httpClient.BaseAddress = new Uri("https://r1-api.dotmailer.com");
                //////////////    var credentials = Encoding.ASCII.GetBytes("apiuser-9c5b9e680cf3@apiconnector.com:stellababy123");
                //////////////    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(credentials));
                //////////////    var result = httpClient.PostAsync(url, new StringContent(content, Encoding.UTF8, "application/json")).Result;
                //////////////}

                //"{ email: \"" + mailid + "\"" + "
                //var url1 = "/v2/email";
                //                //var content1 = @"{ toAddresses: [""stellabaskar@gmail.com""], subject: ""Your order has dispatched"", fromAddress: ""Stella-test1-dotmailer@mycompany.com"", htmlContent: """", plainTextContent: ""Hi. This is to let you know that your order has now been dispatched. Thank you for business."" }";

                //var content1 = "{ toAddresses: [\"" + rdr[0].ToString() + "\"]" + ", CompaignId:5612 , subject: \"This is testmail from Stella!!\", fromAddress: \"Stella-test1-dotmailer@mycompany.com\", htmlContent: \"\", plainTextContent: \"Hi. This is to let you know that your order has now been dispatched. Thank you for business.\" }";

                //var content1 = "{ toAddresses: [\"" + rdr[0].ToString() + "\"]" + ", CampaignId: 5612 }";
                //// var content = @"{ email: ""stellababy@gmail.com"", emailType: ""Html"", dataFields: [ { key: ""FIRSTNAME"", value: ""John"" }, { key: ""FULLNAME"", value: ""John Smith"" }, { key: ""GENDER"", value: ""Male"" }, { key: ""LASTNAME"", value: ""Smith"" }, { key: ""POSTCODE"", value: ""N5 1DP"" } ] }";








                //var content = @"{ email: ""john.smith@example.com"", optInType: ""Single"", emailType: ""Html"", dataFields: [ { key: ""FIRSTNAME"", value: ""John"" }, { key: ""FULLNAME"", value: ""John Smith"" }, { key: ""GENDER"", value: ""Male"" }, { key: ""LASTNAME"", value: ""Smith"" }, { key: ""POSTCODE"", value: ""N5 1DP"" } ] }";


                //var url1 = "/v2/email";
                //var content1 = @"{ ToAddresses: [""stellabaskar@gmail.com""], CampaignID:""4104"", personalizationValues:  [ { key: ""FIRSTNAME"", value: ""John"" }, { key: ""FULLNAME"", value: ""John Smith"" } ] }";
                //var content1 = @"{ toAddresses: [""stellabaskar@gmail.com""], campaignId:""4104"", personalizationValues:  [{ Name: ""FIRSTNAME"" , Value: ""John"" } ] }";

                //using (var httpClient = new HttpClient())
                //{
                //    httpClient.BaseAddress = new Uri("https://r1-api.dotmailer.com");
                //    var credentials = Encoding.ASCII.GetBytes("apiuser-b7e9b94da67a@apiconnector.com:stellabaskar123");
                //    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(credentials));
                //    var result = httpClient.PostAsync(url1, new StringContent(content1, Encoding.UTF8, "application/json")).Result;
                //}
                //var content1 = "{ toAddresses: \"" + rdr[0].ToString() + "\"" + ", subject: \"Your order has dispatched\", fromAddress: \"Stella-test1-dotmailer@mycompany.com\", htmlContent: \"\", plainTextContent: \"Hi. This is to let you know that your order has now been dispatched. Thank you for business.\" }";
                //var content1 = "{ toAddresses: \"" + "stellabaskar@gmail.com" + "\"" + ", subject: \"Your order has dispatched\", fromAddress: \"Stella-test1-dotmailer@mycompany.com\", htmlContent: \"\", plainTextContent: \"Hi. This is to let you know that your order has now been dispatched. Thank you for business.\" }";
                //try
                //{
                //    using (var httpClient = new HttpClient())
                //    {
                //        httpClient.BaseAddress = new Uri("https://r1-api.dotmailer.com");
                //        //var credentials = Encoding.ASCII.GetBytes("apiuser-b7e9b94da67a@apiconnector.com:stellabaskar123");

                //        //var credentials = Encoding.ASCII.GetBytes("transactionalemail-43184beb9e12@apiconnector.com:vsmart123");
                //        var credentials = Encoding.ASCII.GetBytes("apiuser-9c5b9e680cf3@apiconnector.com:stellababy123");

                //        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(credentials));
                //        var result = httpClient.PostAsync(url1, new StringContent(content1, Encoding.UTF8, "application/json")).Result;
                //    }
                //}
                //catch (Exception ex)
                //{
                //    return Json("Error");
                //}
                //finally
                //{
                //}
                //}







                //
            }
             return Json(li, JsonRequestBehavior.AllowGet);


        }


        public ActionResult ManageDb()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ManageDb(string tablename)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
        // GET: /Admin/Create
        public ActionResult Create()
        {

            return View();
        }
        //////public class ResultJson
        //////{
        //////    //public List<Message> messages = new List<Message>();
        //////    public object data { get; set; }
        //////    //public Dictionary<string, string> param = new Dictionary<string, string>();
        //////}
        ////////// POST: /Admin/Create
        ////////// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        ////////// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        ////////[HttpPost]
        ////////[ValidateAntiForgeryToken]
        ////////public ActionResult Create([Bind(Include="id,url,description,category_id,is_public,userid,isActive")] Calendar_Images calendar_images)
        ////////{
        ////////    if (ModelState.IsValid)
        ////////    {
        ////////        db.calendar_Images.Add(calendar_images);
        ////////        db.SaveChanges();
        ////////        return RedirectToAction("Index");
        ////////    }

        ////////    return View(calendar_images);
        ////////}

        ////////// GET: /Admin/Edit/5
        ////////public ActionResult Edit(int? id)
        ////////{
        ////////    if (id == null)
        ////////    {
        ////////        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        ////////    }
        ////////    Calendar_Images calendar_images = db.calendar_Images.Find(id);
        ////////    if (calendar_images == null)
        ////////    {
        ////////        return HttpNotFound();
        ////////    }
        ////////    return View(calendar_images);
        ////////}

        // POST: /Admin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //////[HttpPost]
        //////[ValidateAntiForgeryToken]
        //////public ActionResult Edit([Bind(Include="id,url,description,category_id,is_public,userid,isActive")] Calendar_Images calendar_images)
        //////{
        //////    if (ModelState.IsValid)
        //////    {
        //////        db.Entry(calendar_images).State = EntityState.Modified;
        //////        db.SaveChanges();
        //////        return RedirectToAction("Index");
        //////    }
        //////    return View(calendar_images);
        //////}

        // GET: /Admin/Delete/5
        ////////public ActionResult Delete(int? id)
        ////////{
        ////////    if (id == null)
        ////////    {
        ////////        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        ////////    }
        ////////    Calendar_Images calendar_images = db.calendar_Images.Find(id);
        ////////    if (calendar_images == null)
        ////////    {
        ////////        return HttpNotFound();
        ////////    }
        ////////    return View(calendar_images);
        ////////}

        // POST: /Admin/Delete/5
        ////////[HttpPost, ActionName("Delete")]
        ////////[ValidateAntiForgeryToken]
        ////////public ActionResult DeleteConfirmed(int id)
        ////////{
        ////////    Calendar_Images calendar_images = db.calendar_Images.Find(id);
        ////////    db.calendar_Images.Remove(calendar_images);
        ////////    db.SaveChanges();
        ////////    return RedirectToAction("Index");
        ////////}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
