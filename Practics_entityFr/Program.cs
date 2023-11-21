using Practics_entityFr.DataBase;
using Practics_entityFr.Models;

var dataContext = new UserDB();

dataContext.Users.Add(new User() {Name = "Anvar"});
dataContext.SaveChanges();

dataContext.Users.Add(new User() {Name = "Anxor"});
dataContext.SaveChanges();

dataContext.Users.Add(new User() { Name = "Ansor" });
dataContext.SaveChanges();

var users = dataContext.Users.Where(u=>u.Name.Contains("An")).ToList();

