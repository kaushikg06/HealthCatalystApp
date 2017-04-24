using System.Collections.Generic;
using HealthCatalystApp.Models;
using System.Data.Entity;
using System;

namespace HealthCatalystApp.DAL
{
    /// <summary>
    /// Initializes the people model with dumby data.
    /// This initializer will drop the database each time
    /// the model is accessed.
    /// </summary>
    public class PeopleInitializer : DropCreateDatabaseAlways<PeopleContext>
    {
        protected override void Seed(PeopleContext context)
        {
            List<string[]> people = new List<string[]>();
            var addPeopleList = new List<People>();
            Random random = new Random();

            //Add people to the people list.  This information comes form
            //dumby data source from online.  The information was converted
            //from a csv file.
            people.Add(new string[] { "Kaushik", "Garikipati", "University of Utah", "343 S 500 E", "Salt Lake City", "UT", "84102", "385-259-5591", "garikipatikaushik@gmail.com", "http://www.garikipatikaushik.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Kris", "Marrier", "King, Christopher A Esq", "228 Runamuck Pl #2808", "Baltimore", "MD", "21224", "410-655-8723", "kris@gmail.com", "http://www.kingchristopheraesq.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Minna", "Amigon", "Dorl, James J Esq", "2371 Jerrold Ave", "Kulpsville", "PA", "19443", "215-874-1229", "minna_amigon@yahoo.com", "http://www.dorljamesjesq.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Abel", "Maclead", "Rangoni Of Florence", "37275 St  Rt 17m M", "Middle Island", "NY", "11953", "631-335-3414", "amaclead@gmail.com", "http://www.rangoniofflorence.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Kiley", "Caldarera", "Feiner Bros", "25 E 75th St #69", "Los Angeles", "CA", "90034", "310-498-5651", "kiley.caldarera@aol.com", "http://www.feinerbros.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Graciela", "Ruta", "Buckley Miller & Wright", "98 Connecticut Ave Nw", "Chagrin Falls", "OH", "44023", "440-780-8425", "gruta@cox.net", "http://www.buckleymillerwright.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Cammy", "Albares", "Rousseaux, Michael Esq", "56 E Morehead St", "Laredo", "TX", "78045", "956-537-6195", "calbares@gmail.com", "http://www.rousseauxmichaelesq.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Mattie", "Poquette", "Century Communications", "73 State Road 434 E", "Phoenix", "AZ", "85013", "602-277-4385", "mattie@aol.com", "http://www.centurycommunications.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Meaghan", "Garufi", "Bolton, Wilbur Esq", "69734 E Carrillo St", "Mc Minnville", "TN", "37110", "931-313-9635", "meaghan@hotmail.com", "http://www.boltonwilburesq.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Gladys", "Rim", "T M Byxbee Company Pc", "322 New Horizon Blvd", "Milwaukee", "WI", "53207", "414-661-9598", "gladys.rim@rim.org", "http://www.tmbyxbeecompanypc.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Yuki", "Whobrey", "Farmers Insurance Group", "1 State Route 27", "Taylor", "MI", "48180", "313-288-7937", "yuki_whobrey@aol.com", "http://www.farmersinsurancegroup.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Fletcher", "Flosi", "Post Box Services Plus", "394 Manchester Blvd", "Rockford", "IL", "61109", "815-828-2147", "fletcher.flosi@yahoo.com", "http://www.postboxservicesplus.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Bette", "Nicka", "Sport En Art", "6 S 33rd St", "Aston", "PA", "19014", "610-545-3615", "bette_nicka@cox.net", "http://www.sportenart.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Veronika", "Inouye", "C 4 Network Inc", "6 Greenleaf Ave", "San Jose", "CA", "95111", "408-540-1785", "vinouye@aol.com", "http://www.cnetworkinc.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Willard", "Kolmetz", "Ingalls, Donald R Esq", "618 W Yakima Ave", "Irving", "TX", "75062", "972-303-9197", "willard@hotmail.com", "http://www.ingallsdonaldresq.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Maryann", "Royster", "Franklin, Peter L Esq", "74 S Westgate St", "Albany", "NY", "12204", "518-966-7987", "mroyster@royster.com", "http://www.franklinpeterlesq.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Alisha", "Slusarski", "Wtlz Power 107 Fm", "3273 State St", "Middlesex", "NJ", "8846", "732-658-3154", "alisha@slusarski.com", "http://www.wtlzpowerfm.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Allene", "Iturbide", "Ledecky, David Esq", "1 Central Ave", "Stevens Point", "WI", "54481", "715-662-6764", "allene_iturbide@cox.net", "http://www.ledeckydavidesq.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Chanel", "Caudy", "Professional Image Inc", "86 Nw 66th St #8673", "Shawnee", "KS", "66218", "913-388-2079", "chanel.caudy@caudy.org", "http://www.professionalimageinc.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Ezekiel", "Chui", "Sider, Donald C Esq", "2 Cedar Ave #84", "Easton", "MD", "21601", "410-669-1642", "ezekiel@chui.com", "http://www.siderdonaldcesq.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Willow", "Kusko", "U Pull It", "90991 Thorburn Ave", "New York", "NY", "10011", "212-582-4976", "wkusko@yahoo.com", "http://www.upullit.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Bernardo", "Figeroa", "Clark, Richard Cpa", "386 9th Ave N", "Conroe", "TX", "77301", "936-336-3951", "bfigeroa@aol.com", "http://www.clarkrichardcpa.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Ammie", "Corrio", "Moskowitz, Barry S", "74874 Atlantic Ave", "Columbus", "OH", "43215", "614-801-9788", "ammie@corrio.com", "http://www.moskowitzbarrys.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Francine", "Vocelka", "Cascade Realty Advisors Inc", "366 South Dr", "Las Cruces", "NM", "88011", "505-977-3911", "francine_vocelka@vocelka.com", "http://www.cascaderealtyadvisorsinc.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Ernie", "Stenseth", "Knwz Newsradio", "45 E Liberty St", "Ridgefield Park", "NJ", "7660", "201-709-6245", "ernie_stenseth@aol.com", "http://www.knwznewsradio.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Albina", "Glick", "Giampetro, Anthony D", "4 Ralph Ct", "Dunellen", "NJ", "8812", "732-924-7882", "albina@glick.com", "http://www.giampetroanthonyd.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Alishia", "Sergi", "Milford Enterprises Inc", "2742 Distribution Way", "New York", "NY", "10025", "212-860-1579", "asergi@gmail.com", "http://www.milfordenterprisesinc.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Solange", "Shinko", "Mosocco, Ronald A", "426 Wolf St", "Metairie", "LA", "70002", "504-979-9175", "solange@shinko.com", "http://www.mosoccoronalda.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Jose", "Stockham", "Tri State Refueler Co", "128 Bransten Rd", "New York", "NY", "10011", "212-675-8570", "jose@yahoo.com", "http://www.tristaterefuelerco.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Rozella", "Ostrosky", "Parkway Company", "17 Morena Blvd", "Camarillo", "CA", "93012", "805-832-6163", "rozella.ostrosky@ostrosky.com", "http://www.parkwaycompany.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Valentine", "Gillian", "Fbs Business Finance", "775 W 17th St", "San Antonio", "TX", "78204", "210-812-9597", "valentine_gillian@gmail.com", "http://www.fbsbusinessfinance.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Kati", "Rulapaugh", "Eder Assocs Consltng Engrs Pc", "6980 Dorsett Rd", "Abilene", "KS", "67410", "785-463-7829", "kati.rulapaugh@hotmail.com", "http://www.ederassocsconsltngengrspc.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Youlanda", "Schemmer", "Tri M Tool Inc", "2881 Lewis Rd", "Prineville", "OR", "97754", "541-548-8197", "youlanda@aol.com", "http://www.trimtoolinc.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Dyan", "Oldroyd", "International Eyelets Inc", "7219 Woodfield Rd", "Overland Park", "KS", "66204", "913-413-4604", "doldroyd@aol.com", "http://www.internationaleyeletsinc.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Roxane", "Campain", "Rapid Trading Intl", "1048 Main St", "Fairbanks", "AK", "99708", "907-231-4722", "roxane@hotmail.com", "http://www.rapidtradingintl.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Lavera", "Perin", "Abc Enterprises Inc", "678 3rd Ave", "Miami", "FL", "33196", "305-606-7291", "lperin@perin.org", "http://www.abcenterprisesinc.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Erick", "Ferencz", "Cindy Turner Associates", "20 S Babcock St", "Fairbanks", "AK", "99712", "907-741-1044", "erick.ferencz@aol.com", "http://www.cindyturnerassociates.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Fatima", "Saylors", "Stanton, James D Esq", "2 Lighthouse Ave", "Hopkins", "MN", "55343", "952-768-2416", "fsaylors@saylors.org", "http://www.stantonjamesdesq.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Jina", "Briddick", "Grace Pastries Inc", "38938 Park Blvd", "Boston", "MA", "2128", "617-399-5124", "jina_briddick@briddick.com", "http://www.gracepastriesinc.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Kanisha", "Waycott", "Schroer, Gene E Esq", "5 Tomahawk Dr", "Los Angeles", "CA", "90006", "323-453-2780", "kanisha_waycott@yahoo.com", "http://www.schroergeneeesq.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Emerson", "Bowley", "Knights Inn", "762 S Main St", "Madison", "WI", "53711", "608-336-7444", "emerson.bowley@bowley.org", "http://www.knightsinn.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });
            people.Add(new string[] { "Blair", "Malet", "Bollinger Mach Shp & Shipyard", "209 Decker Dr", "Philadelphia", "PA", "19132", "215-907-9111", "bmalet@yahoo.com", "http://www.bollingermachshpshipyard.com", "/Content/img/personimg.jpg", "Biking, Running, Bowling, Tennis, Reading and Shopping", random.Next(0, 100).ToString() });


            //Loop goes through the list that contains the array of information
            //about hte people
            foreach (var p in people)
            {

                //For each list in list, create a people object
                People item = new People
                {
                    first_name = p[0],
                    last_name = p[1],
                    company = p[2],
                    address = p[3],
                    city = p[4],
                    state = p[5],
                    zip = p[6],
                    phone = p[7],
                    email = p[8],
                    website = p[9],
                    photo_path = p[10],
                    interests = p[11],
                    age = Int32.Parse(p[12]),

                };


                //add each people object to the add list
                addPeopleList.Add(item);

            }

            //For each object in the add list, add them using
            //the data context
            addPeopleList.ForEach(s => context.People.Add(s));
            context.SaveChanges();
            
        }
    }
}