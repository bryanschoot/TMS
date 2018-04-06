using System;
using System.Collections.Generic;
using TMS.Model;

namespace TMS.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int AccountId = 1;
            int AddressId = 1;

            List<AccountModel> Accounts = new List<AccountModel>();
            List<AddressModel> Addresses = new List<AddressModel>();

            Addresses.Add(new AddressModel(AddressId++, "Belle van Zuylenstraat", "30", "6836PZ", "Arnhem", "Nederland"));
            Accounts.Add(new AccountModel(AccountId++, "bdjschoot@gmail.com", "Secret", "Bryan", "Schoot", 18, Addresses[0]));

            Addresses.Add(new AddressModel(AddressId++, "Marxsingel", "10", "6836JC", "Arnhem", "Nederland"));
            Accounts.Add(new AccountModel(AccountId++, "svenschoot@gmail.com", "Onbekend", "Sven", "Schoot", 20, Addresses[1]));

            foreach (var Account in Accounts)
            {
                System.Console.WriteLine(Account);
            }
        }
    }
}