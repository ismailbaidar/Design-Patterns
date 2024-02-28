


using ConsoleApp1;

User user = new UserBuilder("Something").SetAddress(new Address("Rabat", "1212")).Build();
User userOld = new User("hello",null,null,new Address("ABC","123"));
Console.WriteLine(user);
Console.WriteLine(userOld);