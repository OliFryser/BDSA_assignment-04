using Assignment.Infrastructure;
using Assignment.Core;

var factory = new KanbanContextFactory();
using var context = factory.CreateDbContext(args);

var UserRepository = new UserRepository(context);
UserRepository.Create(new UserCreateDTO("Bob", "Bob@jensen.dk"));
var user = UserRepository.Find(1);

Console.WriteLine(user.Name);