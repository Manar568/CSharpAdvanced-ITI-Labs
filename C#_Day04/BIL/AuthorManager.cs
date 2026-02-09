using System.Data;
using BIL.Model;
using DAL;
using System.Collections.Generic;


namespace BIL
{
    public class AuthorManager
    {
        PublishingDAL publishingdal;

        public AuthorManager()
        {
            publishingdal = new PublishingDAL();
        }


        public string AddAuthor(Author author)
        {
            int contractValue = author.Contract ? 1 : 0;

            int rowAffected = publishingdal.ExecuteNonQuery($"INSERT INTO authors (au_id, au_fname, au_lname, phone, contract) VALUES" +
                $" ('{author.Id}', '{author.FName}', '{author.LName}', '{author.Phone}', {contractValue})");


                   return $"{rowAffected} row affected";

        }

        public string DeleteAuthor(string id )
        {
            if (string.IsNullOrWhiteSpace(id))
                return "uncorrect id ";

            if (id.Length != 11)
                return "id must be 11 char";

            int rowAffected = publishingdal.ExecuteNonQuery($"delete from authors where au_id = '{id}'");

            return $"{rowAffected} row affected";
        }


        public List<Author> GetAllAuthors()
        {
            DataTable allAuthors = publishingdal.GetAllAuthors("select * from authors");

            List<Author> result= new List<Author>();

            foreach (DataRow row in allAuthors.Rows)
            {
                Author author = new Author
                {
                    Id = row["au_id"].ToString(),
                    FName = row["au_fname"].ToString(),
                    LName = row["au_lname"].ToString(),
                    Phone = row["phone"].ToString(),
                    Address = row["address"].ToString(),
                    City = row["city"].ToString(),
                    State = row["state"].ToString(),
                    Zip = row["zip"].ToString(),
                    Contract = Convert.ToBoolean(row["contract"])
                };
                result.Add(author);
            }
            return result;



        }



    }
}
