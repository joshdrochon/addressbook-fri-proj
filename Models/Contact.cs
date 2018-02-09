using System;

//imports Collections to use List data type
using System.Collections.Generic;

namespace AddressBook.Models
{
  //Contact class
  public class Contact
  {
    //properties of all Contact instances
    private string _name;
    private int _id;

    private string _email;
    private string _phone;


    //static list encapsulates all instances of class
    private static List<Contact> _instances = new List<Contact> {};


    //Contact Constructor
    public Contact (string Name, string Email, string Phone)
    {
      this._name = Name;
      this._email = Email;
      this._phone = Phone;


      _instances.Add(this);
      _id = _instances.Count;
    }

    //_name setter/getter
    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetName()
    {
      return _name;
    }

    //_id setter/getter
    public void SetId(int newId)
    {
      _id = newId;
    }
    public int GetId()
    {
    return _id;
    }

    //email setter/getter
    public void SetEmail(string newEmail)
    {
      _email = newEmail;
    }
    public string GetEmail()
    {
      return _email;
    }

    //phone setter/getter
    public void SetPhone(string newPhone)
    {
      _phone = newPhone;
    }
    public string GetPhone()
    {
      return _phone;
    }


    public static List<Contact> GetAll()
    {
      return _instances;
    }

    public void Save()
    {
      _instances.Add(this);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  } //end Contact class
}//end AddressBook namespace
