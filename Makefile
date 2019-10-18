run:
	dotnet run --project=Scooby.Api

build:
	dotnet build

migrate:
	dotnet ef migrations add $(name) --project=Scooby.Api

update:
	dotnet ef database update --project=Scooby.Api