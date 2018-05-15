using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data;

namespace Session
{
    public class Broker
    {
        OleDbConnection connection;
        OleDbCommand command;

        private void ConnectTo()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\joaot\Documents\visual studio 2012\Projects\Access\Database.accdb;Persist Security Info=False");
            command = connection.CreateCommand();
        }

        public Broker()
        {
            ConnectTo();
        }

        public void Insert(Person p)
        {
            try
            {
                command.CommandText = "INSERT INTO TPersons (FisrtName, LastName) VALUES ('" + p.FisrtName + "', '" + p.LastName + "')";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public List<Person> FillComboBox()
        {
            List<Person> personList = new List<Person>();

            try
            {
                command.CommandText = "SELECT * FROM TPersons";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Person p = new Person();

                    p.Id = Convert.ToInt32(reader["ID"].ToString());
                    p.FisrtName = reader["FisrtName"].ToString();
                    p.LastName = reader["LastName"].ToString();

                    personList.Add(p);
                }
                return personList;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void Update(Person oldPerson, Person newPerson)
        {
            try
            {
                command.CommandText = "UPDATE TPersons SET FisrtName = '" + newPerson.FisrtName + "', LastName = '" + newPerson.LastName + "' WHERE ID = " + oldPerson.Id;
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void Delete(Person p)
        {
            try
            {
                command.CommandText = "DELETE FROM TPersons WHERE ID = " + p.Id;
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
    }
}
