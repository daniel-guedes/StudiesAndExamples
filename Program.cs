using MiniToDo.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

app.MapGet("V1/todos", (AppDbContext context) => {
	var todos = context.Todos.ToList();
	return Results.Ok(todos);
});

app.Run();
