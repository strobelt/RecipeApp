use master
create login recipedb with password = 'R3c1p3@pp' 
create database RecipeDb
go
use RecipeDb
create user recipedb for login recipedb
alter role db_owner add member recipedb
