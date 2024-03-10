var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
	var todo = new ToDo(Guid.NewGuid(), "Criar testes automatizados", false);
	return Results.Ok(todo);
});

app.Run();
