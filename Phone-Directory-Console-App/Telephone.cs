namespace Telephone_Directory
{
    public class Telephone
    {
        protected string Name;
        protected string Surname;
        protected int TelephoneNumber;
          public void SaveTelephoneNumber(string name,string surname,int telephoneNumber){
            this.Name = name;
            this.Surname = surname;
            this.TelephoneNumber = telephoneNumber;
          }

          public void DeleteTelephoneNumber(int telephoneNumber){
            
          }

          public void UpdateTelephoneNumber(){}

          public void ListDirectory(){}

          public void SearchRecords(){}
    }
}