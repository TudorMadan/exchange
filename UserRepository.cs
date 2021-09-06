using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Crmf;

namespace proiect
{
    class UserRepository
    {

        DBConnect con = new DBConnect();

        public void Insert(string query)
        {
            
            //deschide conexiunea
            if (con.OpenConnection() == true)
            {
                //creați comanda și atribuiți interogarea și conexiunea din constructor
                MySqlCommand cmd = new MySqlCommand(query, con.connection);

                //Executa comanda
                cmd.ExecuteNonQuery();

                //inchide conexiunea
                con.CloseConnection();
            }
        }

        public string InsertId(string query)
        {
            
            string query1 = "SELECT LAST_INSERT_ID()";

            //Create a list to store the result
            List<string> list = new List<string>();
            string data = "";
            //Open connection
            if (con.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, con.connection);
                MySqlCommand cmd2 = new MySqlCommand(query1, con.connection);
                cmd.ExecuteNonQuery();
                MySqlDataReader dataReader = cmd2.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    data = dataReader["LAST_INSERT_ID()"].ToString() ;
                    

                }


                //close Connection
                con.CloseConnection();

                //return list to be displayed
                return data;
            }
            else
            {
                //close Connection
                con.CloseConnection();
                return null;
            }
        }

        public List<string>[] getUser(string username)
        {
            string query = "SELECT * FROM users where username = '"+username+"'";

            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();

            if (con.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, con.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["username"] + "");
                    list[2].Add(dataReader["password"] + "");
                    list[3].Add(dataReader["email"] + "");
                    list[4].Add(dataReader["idfirma"] + "");
                    list[5].Add(dataReader["idpoints"] + "");



                }


                con.CloseConnection();

                return list;
            }
            else
            {
                con.CloseConnection();
                return null;
            }
        }

        public List<string> getUserPoints(int idFirma)
        {
            string query = "SELECT * FROM points where idfirma = '" + idFirma + "'";

            //Create a list to store the result
            List<string> list = new List<string>();

            //Open connection
            if (con.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, con.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    string data = dataReader["id"] + "@" + dataReader["pointname"] + "@" + dataReader["idfirma"];
                    list.Add(data.ToString());

                }


                //close Connection
                con.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                //close Connection
                con.CloseConnection();
                return null;
            }
        }
        public List<string> getTranzactii(string data1,string data2, string idpoint,string idfirma="")
        {
            string query = "";
            if (idfirma=="")
            {
                query = "SELECT t.id, t.idclient, t.idpoint, t.rata_schimb, t.created_at, t.nume_moneda_cumparata, t.nume_moneda_vanduta, t.observatii, t.cantitate, p.pointname, c.firstname, c.lastname" + 
                    " FROM clients c, transactions t, points p where t.idpoint =" + idpoint + " and t.created_at between '" + data1 + "' and '" + data2 + "'"
                    + " AND t.idpoint=p.id"  + " AND t.idclient=c.id"                  
                    + " order by created_at DESC";

            }
            else
            {
                query = "SELECT t.id, t.idclient, t.idpoint, t.rata_schimb, t.created_at, t.nume_moneda_cumparata, t.nume_moneda_vanduta, t.observatii, t.cantitate, p.pointname, c.firstname, c.lastname" + 
                    " FROM clients c, transactions t, points p where t.idfirma =" + idfirma + " and created_at between '" + data1 + "' and '" + data2 + "'"
                    + " AND t.idpoint=p.id" + " AND t.idclient=c.id"
                    + " order by created_at DESC";
            }

            //Create a list to store the result
            List<string> list = new List<string>();

            //Open connection
            if (con.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, con.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    string data = dataReader["id"] + "@" + dataReader["idclient"] + "@" + dataReader["idpoint"] + "@" + dataReader["rata_schimb"] + "@" + dataReader["created_at"] + "@" + dataReader["nume_moneda_cumparata"] + "@" + dataReader["nume_moneda_vanduta"]
                        + "@" + dataReader["observatii"] + "@" + dataReader["cantitate"] + "@" + dataReader["pointname"] + "@" + dataReader["firstname"] + "@" + dataReader["lastname"];
                    list.Add(data.ToString());

                }


                //close Connection
                con.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                //close Connection
                con.CloseConnection();
                return null;
            }
        }

        
        public List<CursuriIstoric> getRatesHistory(string data1, string data2, string idpoint)
        {
            List < CursuriIstoric > a= new List<CursuriIstoric>();
            string query = "SELECT r.id,r.idpoints,DATE_FORMAT(r.created_at, '%Y-%m-%d') as 'cr',c.nume_moneda,r.rata_cumparare,r.rata_vanzare FROM rates_history r,currencies c where r.idcurrency=c.id and r.idpoints = " + idpoint + " and r.created_at between '" + data1 + "' and '" + data2 + "' order by cr asc,r.idcurrency ";

            
            //Open connection
            if (con.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, con.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();
                string test="";
                string test2 = "";
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    CursuriIstoric b = new CursuriIstoric();
                    var cr = dataReader["cr"].ToString();
                    var nume_moneda = dataReader["nume_moneda"].ToString();
                    if ((test==cr)&&(test2==nume_moneda))
                    {
                        
                    }
                    else
                    {
                        b.created_at = cr;
                        b.nume_moneda = nume_moneda;
                        b.rata_medie = (float.Parse(dataReader["rata_cumparare"].ToString()) + float.Parse(dataReader["rata_vanzare"].ToString())) / 2;
                        a.Add(b);
                        
                        test = cr;
                        test2 = nume_moneda;

                    }
                    

                }


                //close Connection
                con.CloseConnection();

                //return list to be displayed
                return a;
            }
            else
            {
                //close Connection
                con.CloseConnection();
                return null;
            }
        }

        public List<string> getProfit(string data1, string data2, string idpoint,string idfirma="")
        {
            string query;
            if (idfirma == "")
            {
                query = "SELECT * FROM transactions where idpoint = " + idpoint + " and created_at between '" + data1 + "' and '" + data2 + "' order by created_at DESC";

            }
            else
            {
                query = "SELECT * FROM transactions where idfirma = " + idfirma + " and created_at between '" + data1 + "' and '" + data2 + "' order by created_at DESC";

            }

            //Create a list to store the result
            List<string> list = new List<string>();

            //Open connection
            if (con.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, con.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    string data = dataReader["id"] + "@" + dataReader["pointname"] + "@" + dataReader["idfirma"];
                    list.Add(data.ToString());

                }


                //close Connection
                con.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                //close Connection
                con.CloseConnection();
                return null;
            }
        }

        public List<string> getSold(int idPoint)
        {
            string query = "SELECT currencies.nume_moneda, currencies.prescurtare_moneda, currency_point.cantitate FROM currency_point inner join currencies on currency_point.idcurrency = currencies.id where idpoint = " + idPoint.ToString();

            List<string> list = new List<string>();

            //Open connection
            if (con.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, con.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                //close Connection
                //con.CloseConnection();
                while (dataReader.Read())
                {
                    string data = dataReader["nume_moneda"] + "@" + dataReader["prescurtare_moneda"] + "@" + dataReader["cantitate"];
                    list.Add(data.ToString());

                }

                return list;


                //return list to be displayed

            }
            else
            {
                return null;
            }
        }

        public List<string> getCursuriBnr()
        {
            string query = "SELECT currencies.nume_moneda, currencies.prescurtare_moneda, currency_point.cantitate FROM currency_point inner join currencies on currency_point.idcurrency = currencies.id where idpoint = " ;

            List<string> list = new List<string>();

            //Open connection
            if (con.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, con.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                //close Connection
                //con.CloseConnection();
                while (dataReader.Read())
                {
                    string data = dataReader["nume_moneda"] + "@" + dataReader["prescurtare_moneda"] + "@" + dataReader["cantitate"];
                    list.Add(data.ToString());

                }

                return list;


                //return list to be displayed

            }
            else
            {
                return null;
            }
        }

        public List<string> getSoldList(int idPoint)
        {
            string query = "SELECT currencies.id, currencies.nume_moneda, currency_point.cantitate FROM currency_point inner join currencies on currency_point.idcurrency = currencies.id where idpoint = " + idPoint.ToString();
           
            //Create a list to store the result
            List<string> list = new List<string>();

            //Open connection
            if (con.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, con.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                //close Connection
                //con.CloseConnection();


                // Read the data and store them in the list
                while (dataReader.Read())
                {
                    string data = dataReader["id"] + "@" + dataReader["nume_moneda"] + "@" + dataReader["cantitate"];
                    list.Add(data.ToString());

                }
                //close Connection
                con.CloseConnection();

                return list;

                //return list to be displayed

            }
            else
            {
                //close Connection
                con.CloseConnection();
                return null;
            }
        }

        public List<string> getTransferInt(int idpoint)
        {
            string query = "select t.id, t.idpoint_trimis, t.idpoint_primit, t.idcurrency, t.cantitate, t.created_at, t.incasat, p.pointname, c.prescurtare_moneda, c.id as 'c.id'" +
                           " FROM transferint t, points p, currencies c" +
                           " WHERE t.idpoint_primit = " + idpoint +
                           " AND t.incasat = 0" +
                           " AND t.idpoint_trimis = p.id" +
                           " AND t.idcurrency = c.id";

            List<string> list = new List<string>();

            if (con.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, con.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string data = dataReader["id"] + "@" + dataReader["idpoint_trimis"] + "@" + dataReader["idpoint_primit"] +
                                  "@" + dataReader["idcurrency"] + "@" + dataReader["cantitate"] + '@' + dataReader["created_at"] + '@' 
                                  + dataReader["incasat"] + '@' + dataReader["pointname"] + '@' + dataReader["prescurtare_moneda"] + '@' 
                                  + dataReader["c.id"];

                    list.Add(data.ToString());

                }


                con.CloseConnection();

                return list;
            }
            else
            {
                return null;
            }
        }

        public List<string> getRatesData(int idpoint)
        {
            string query = "select  c.nume_moneda, c.prescurtare_moneda, cp.cantitate, r.rata_cumparare , r.rata_vanzare, c.id, r.id as 'r.id'" + 
                           " FROM currency_point cp, currencies c, rates r"+
                           " WHERE r.idpoints =" + idpoint +
                           " AND cp.idpoint=r.idpoints " +
                           " AND c.id = r.idcurrency" +
                           " and cp.idcurrency =c.id " +
                           " ORDER BY c.id";

            //Create a list to store the result
            List<string> list = new List<string>();

            //Open connection
            if (con.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, con.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    string data =  dataReader["nume_moneda"] + "@" + dataReader["prescurtare_moneda"] + "@" + dataReader["cantitate"] +
                                  "@" + dataReader["rata_cumparare"] + "@" + dataReader["rata_vanzare"]+'@'+dataReader["id"]+'@'+dataReader["r.id"];

                   list.Add(data.ToString());

                }


                //close Connection
                con.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return null;
            }
        }

        public List<string> getClientsUltimul(int idFirma,int idPoint)
        {
            string query = "select  c.firstname, c.lastname, c.informatii, c.serie, c.numar, c.cnp, c.id" +
                           " FROM clients c " +
                           " WHERE c.id = (select t.idclient from transactions t " +
                           " where t.idfirma =" +idFirma.ToString() +
                           " and t.idpoint = "+idPoint.ToString() +
                           " order by t.created_at DESC limit 1)"
                           ;

            List<string> list = new List<string>();

            if (con.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, con.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string data = dataReader["firstname"] + "@" + dataReader["lastname"] + "@" + dataReader["informatii"] +
                                  "@" + dataReader["serie"] + "@" + dataReader["numar"] + '@' + dataReader["cnp"] + '@' + dataReader["id"];

                    list.Add(data.ToString());

                }


                con.CloseConnection();

                return list;
            }
            else
            {
                con.CloseConnection();
                return null;
            }
        }

        public List<string> getClientsNume(int idFirma,  string nume)
        {
            string query = "select  c.firstname, c.lastname, c.informatii, c.serie, c.numar, c.cnp, c.id" +
                           " FROM clients c " +
                           " WHERE c.firstname like  '" + nume +"'"+
                           " and c.idfirma =" + idFirma.ToString();
                         

            //Create a list to store the result
            List<string> list = new List<string>();

            //Open connection
            if (con.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, con.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    string data = dataReader["firstname"] + "@" + dataReader["lastname"] + "@" + dataReader["informatii"] +
                                  "@" + dataReader["serie"] + "@" + dataReader["numar"] + '@' + dataReader["cnp"] + '@' + dataReader["id"];

                    list.Add(data.ToString());

                }


                //close Connection
                con.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                //close Connection
                con.CloseConnection();
                return null;
            }
        }

        public List<string> getClientsId(int idFirma, string numar)
        {
            string query = "select  c.firstname, c.lastname, c.informatii, c.serie, c.numar, c.cnp, c.id" +
                            " FROM clients c " +
                            " WHERE c.numar = " + numar +
                            " and c.idfirma =" + idFirma.ToString();


            //Create a list to store the result
            List<string> list = new List<string>();

            //Open connection
            if (con.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, con.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    string data = dataReader["firstname"] + "@" + dataReader["lastname"] + "@" + dataReader["informatii"] +
                                  "@" + dataReader["serie"] + "@" + dataReader["numar"] + '@' + dataReader["cnp"] + '@' + dataReader["id"];

                    list.Add(data.ToString());

                }


                //close Connection
                con.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                //close Connection
                con.CloseConnection();
                return null;
            }
        }

        public string[] getAdresaPointname ()
        {
            string[] rezultat=new string[4];
            string query = "select p.pointname,p.adresa,f.cui,f.numefirma from points p,firme f where p.idfirma=f.id and p.id=" + Globals.IdPoints.ToString();
            if (con.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, con.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    
                    rezultat[0] = dataReader["pointname"].ToString();
                    rezultat[1] = dataReader["adresa"].ToString();
                    rezultat[2] = dataReader["cui"].ToString();
                    rezultat[3] = dataReader["numefirma"].ToString();





                }


                //close Connection
                con.CloseConnection();

                //return list to be displayed
                return rezultat;
            }
            else
            {
                //close Connection
                con.CloseConnection();
                return null;
            }
        
            
        }

        public formularAcceptare getFormularAcceptare(string id)
        {
            formularAcceptare a = new formularAcceptare();
            string query = "SELECT * FROM formulare where id = '" + id + "'";
            

            if (con.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, con.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    a.id = id;
                    a.pointname=dataReader["pointname"].ToString();
                    a.adresa=dataReader["adresa"].ToString();
                    a.created_at=dataReader["created_at"].ToString();
                    a.nume=dataReader["nume"].ToString();
                    a.prenume=dataReader["prenume"].ToString();
                    a.serie=dataReader["serie"].ToString();
                    a.numar= dataReader["numar"].ToString();
                    a.suma_tranz= dataReader["suma_tranz"].ToString();
                    a.curs= dataReader["curs"].ToString();
                    a.suma_incasata= dataReader["suma_incasata"].ToString();
                    a.moneda_cump = dataReader["moneda_cump"].ToString();
                    a.moneda_vand = dataReader["moneda_vand"].ToString();



                }


                con.CloseConnection();

                return a;
            }
            else
            {
                con.CloseConnection();
                return null;
            }
        }

        public string[] getRegister(string cod_licenta)
        {
            string[] rezultat = new string[2];
            string query = "select idfirma,idpoints from licente where cod=" + cod_licenta;
            if (con.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, con.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {

                    rezultat[0] = dataReader["idfirma"].ToString();
                    rezultat[1] = dataReader["idpoints"].ToString();




                }


                //close Connection
                con.CloseConnection();

                //return list to be displayed
                return rezultat;
            }
            else
            {
                //close Connection
                con.CloseConnection();
                return null;
            }


        }

        public string[] getMachetaCursuri()
        {
            string[] informatii = new string[5];
            informatii[0] = Globals.NumeFirma;
            informatii[1] = Globals.Cui;
            informatii[2] = Globals.Adresa;
            informatii[3] = DateTime.Now.ToString();
            informatii[4] = Globals.PointName;
            return informatii;
        }

    }
}
