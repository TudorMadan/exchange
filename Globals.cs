using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;

namespace proiect
{
    public class Globals
    {
        private static int userId;
        public static int UserId
        {
            get
            {
                // Reads are usually simple
                return userId;
            }
            set
            {
                // You can add logic here for race conditions,
                // or other measurements
                userId = value;
            }
        }
        private static string userName;
        public static string UserName
        {
            get
            {
                // Reads are usually simple
                return userName;
            }
            set
            {
                // You can add logic here for race conditions,
                // or other measurements
                userName = value;
            }
        }
        private static string cui;
        public static string Cui
        {
            get
            {
                // Reads are usually simple
                return cui;
            }
            set
            {
                // You can add logic here for race conditions,
                // or other measurements
                cui = value;
            }
        }
        private static string adresa;
        public static string Adresa
        {
            get
            {
                // Reads are usually simple
                return adresa;
            }
            set
            {
                // You can add logic here for race conditions,
                // or other measurements
                adresa = value;
            }
        }

        private static int idFirma;
        public static int IdFirma
        {
            get
            {
                // Reads are usually simple
                return idFirma;
            }
            set
            {
                // You can add logic here for race conditions,
                // or other measurements
                idFirma = value;
            }

        }
        private static string numeFirma;
        public static string NumeFirma
        {
            get
            {
                // Reads are usually simple
                return numeFirma;
            }
            set
            {
                // You can add logic here for race conditions,
                // or other measurements
                numeFirma = value;
            }
        }

        private static int idPoints;
        public static int IdPoints
        {
            get
            {
                // Reads are usually simple
                return idPoints;
            }
            set
            {
                // You can add logic here for race conditions,
                // or other measurements
                idPoints = value;
            }
        }

        private static string pointname;
        public static string PointName
        {
            get
            {
                return pointname;
            }
            set
            {
                pointname = value;
            }
        }

        

        // Perhaps extend this to have Read-Modify-Write static methods
        // for data integrity during concurrency? Situational.

    }
}
