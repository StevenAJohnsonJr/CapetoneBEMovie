using CapstoneBEMovie;
using CapstoneBEMovie.Models;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// allows passing datetimes without time zone data 
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);


// allows our api endpoints to access the database through Entity Framework Core
builder.Services.AddNpgsql<CapstoneBEMovieDbContext>(builder.Configuration["CapstoneBEMovieDbConnectionString"]);

// Set the JSON serializer options
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;

});

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins("http://localhost:3000",
                                "http://localhost:5169")
                                .AllowAnyHeader()
                                .AllowAnyMethod()
                                .AllowAnyOrigin();
        });
});

var app = builder.Build();

app.UseCors();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//movies

app.MapGet("/movie", (CapstoneBEMovieDbContext db) =>
{
    return db.Movies.ToList();
});

app.MapGet("/api/MoviesbyGenreID/{genreid}", (CapstoneBEMovieDbContext db, int genreid) =>
{
    var movie = db.Movies.Where(s => s.GenreId == genreid)
    .Include(s => s.Genre).ToList();
    return movie;
}
);

app.MapGet("/api/MoviesbyDirectorId/{directorid}", (CapstoneBEMovieDbContext db, int directorid) =>
{
    var movie = db.Movies.Where(s => s.DirectorId == directorid)
    .Include(s => s.Genre).ToList();
    return movie;
}
);

app.MapGet("/movie1", (CapstoneBEMovieDbContext db) =>
{
    var movies = db.Movies
        .Where(s => s.GenreId == 1)
        .Include(s => s.Genre)
        .ToList();

    return movies;
});

app.MapGet("/movie2", (CapstoneBEMovieDbContext db) =>
{
    var movies = db.Movies
        .Where(s => s.GenreId == 2)
        .Include(s => s.Genre)
        .ToList();

    return movies;
});

app.MapGet("/movie3", (CapstoneBEMovieDbContext db) =>
{
    var movies = db.Movies
        .Where(s => s.GenreId == 3)
        .Include(s => s.Genre)
        .ToList();

    return movies;
});

app.MapGet("/movie4", (CapstoneBEMovieDbContext db) =>
{
    var movies = db.Movies
        .Where(s => s.GenreId == 4)
        .Include(s => s.Genre)
        .ToList();

    return movies;
});

app.MapGet("/movie5", (CapstoneBEMovieDbContext db) =>
{
    var movies = db.Movies
        .Where(s => s.GenreId == 5)
        .Include(s => s.Genre)
        .ToList();

    return movies;
});

app.MapGet("/movie6", (CapstoneBEMovieDbContext db) =>
{
    var movies = db.Movies
        .Where(s => s.GenreId == 6)
        .Include(s => s.Genre)
        .ToList();

    return movies;
});

app.MapGet("/movie7", (CapstoneBEMovieDbContext db) =>
{
    var movies = db.Movies
        .Where(s => s.GenreId == 7)
        .Include(s => s.Genre)
        .ToList();

    return movies;
});

app.MapGet("/movie8", (CapstoneBEMovieDbContext db) =>
{
    var movies = db.Movies
        .Where(s => s.GenreId == 8)
        .Include(s => s.Genre)
        .ToList();

    return movies;
});

app.MapGet("/movie9", (CapstoneBEMovieDbContext db) =>
{
    var movies = db.Movies
        .Where(s => s.GenreId == 9)
        .Include(s => s.Genre)
        .ToList();

    return movies;
});

app.MapGet("/movie10", (CapstoneBEMovieDbContext db) =>
{
    var movies = db.Movies
        .Where(s => s.GenreId == 10)
        .Include(s => s.Genre)
        .ToList();

    return movies;
});

app.MapGet("/movie11", (CapstoneBEMovieDbContext db) =>
{
    var movies = db.Movies
        .Where(s => s.GenreId == 11)
        .Include(s => s.Genre)
        .ToList();

    return movies;
});
app.MapGet("/movie/{id}", (CapstoneBEMovieDbContext db, int id) =>
{
    var movies = db.Movies.SingleOrDefaultAsync(u => u.Id == id);
    return movies;
});

app.MapGet("/api/MoviesbyDirectorId/{id}", (CapstoneBEMovieDbContext db, int id) =>
{
    var movie = db.Movies.Where(s => s.DirectorId == id)
    .Include(s => s.Director).ToList();
    return movie;
}
);

app.MapPost("/api/movie", (CapstoneBEMovieDbContext db, Movie movie) =>
{
    db.Movies.Add(movie);
    db.SaveChanges();
    return Results.Created($"/api/item/{movie.Id}", movie);
});

app.MapPost("/api/editItem", (CapstoneBEMovieDbContext db, Movie movie) =>
{    
    var existingItem = db.Movies.Find(movie.Id);

    if (existingItem != null)
    {
        // Handle the case where the movie already exists, e.g., return a conflict response.
        return Results.Conflict($"Item with ID {movie.Id} already exists.");
    }

    // If the item does not exist, add and save it to the database
    db.Movies.Add(movie);
    db.SaveChanges();

    return Results.Created($"/api/movie/{movie.Id}", movie);
});

app.MapPut("/movie/{id}", (CapstoneBEMovieDbContext db, int id, Movie movie) =>
{
    Movie itemToUpdate = db.Movies.FirstOrDefault(c => c.Id == id);
    if (itemToUpdate == null)
    {
        return Results.NotFound();
    }
    itemToUpdate.Id = movie.Id;
    itemToUpdate.DirectorId = movie.DirectorId;
    itemToUpdate.GenreId = movie.GenreId;
    itemToUpdate.Description = movie.Description;
    itemToUpdate.Year = movie.Year;
    itemToUpdate.Length = movie.Length;
    itemToUpdate.IsForeign = movie.IsForeign;
    itemToUpdate.Rated = movie.Rated;
    itemToUpdate.SteamingOn = movie.SteamingOn;
    itemToUpdate.ImgUrl = movie.ImgUrl;

    db.SaveChanges();
    return Results.Ok(movie);
});

app.MapDelete("/api/moviebyID/{id}", (CapstoneBEMovieDbContext db, int id) =>
{
    Movie movie = db.Movies.SingleOrDefault(item => item.Id == id);
    if (movie == null)
    {
        return Results.NotFound();
    }
    db.Movies.Remove(movie);
    db.SaveChanges();
    return Results.NoContent();
});

//directors

app.MapGet("/director", (CapstoneBEMovieDbContext db) =>
{
    return db.Directors.ToList();
});

app.MapGet("/director/{id}", (CapstoneBEMovieDbContext db, int id) =>
{
    var directors = db.Directors.SingleOrDefaultAsync(u => u.Id == id);
    return directors;
});

app.MapPost("/api/director", (CapstoneBEMovieDbContext db, Director director) =>
{
    db.Directors.Add(director);
    db.SaveChanges();
    return Results.Created($"/api/director/{director.Id}", director);
});

app.MapPost("/api/editItems", (CapstoneBEMovieDbContext db, Director director) =>
{
    // Check if an item with the same ID already exists
    var existingItem = db.Directors.Find(director.Id);

    if (existingItem != null)
    {
        // Handle the case where the item already exists, e.g., return a conflict response.
        return Results.Conflict($"Director with ID {director.Id} already exists.");
    }

    // If the item does not exist, add and save it to the database
    db.Directors.Add(director);
    db.SaveChanges();

    return Results.Created($"/api/director/{director.Id}", director);
});

app.MapPut("/director/{id}", (CapstoneBEMovieDbContext db, int id, Director director) =>
{
    Director directorToUpdate = db.Directors.FirstOrDefault(c => c.Id == id);
    if (directorToUpdate == null)
    {
        return Results.NotFound();
    }
    directorToUpdate.DirectorName = director.DirectorName;
    directorToUpdate.Id = director.Id;
    
    db.SaveChanges();
    return Results.Ok(director);
});

app.MapDelete("/api/directorsbyID/{id}", (CapstoneBEMovieDbContext db, int id) =>
{
    Director director = db.Directors.SingleOrDefault(director => director.Id == id);
    if (director == null)
    {
        return Results.NotFound();
    }
    db.Directors.Remove(director);
    db.SaveChanges();
    return Results.NoContent();

}); 

//genres

app.MapGet("/genre", (CapstoneBEMovieDbContext db) =>
{
    return db.Genres.ToList();
});

app.MapGet("/genrebyName/{genrename}", (CapstoneBEMovieDbContext db, string genrename) =>
{
    var genres = db.Genres.SingleOrDefaultAsync(u => u.GenreName == genrename);
    return genres;
});

app.MapGet("/genreById/{id}", (CapstoneBEMovieDbContext db, int id) =>
{
    var genres = db.Genres.SingleOrDefaultAsync(u => u.Id == id);
    return genres;
});




//users

app.MapGet("/checkuser/{uid}", (CapstoneBEMovieDbContext db, string uid) =>
{
    var user = db.Users.Where(x => x.Uid == uid).ToList();
    if (uid == null)
    {
        return Results.NotFound();
    }
    else
    {
        return Results.Ok(user);
    }
});

app.MapGet("/user", (CapstoneBEMovieDbContext db) =>
{
    return db.Users.ToList();
});

app.MapGet("/users/{id}", (CapstoneBEMovieDbContext db, int id) =>
{
    var user = db.Users.Where(u => u.Id == id);
    return user;
});

app.Run();
