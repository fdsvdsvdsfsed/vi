type Genre =
    | Horror
    | Drama
    | Thriller
    | Comedy
    | Fantasy
    | Sport

type Director = {
    Name: string
    Movies: int
}

type Movie = {
    Name: string
    RunLength: int
    Genre: Genre
    Director: Director
    IMDBRating: float
}

let director1 = { Name = "Sian Heder"; Movies = 9 }
let director2 = { Name = "Kenneth Branagh"; Movies = 23 }
let director3 = { Name = "Adam McKay"; Movies = 27 }
let director4 = { Name = "Ryusuke Hamaguchi"; Movies = 16 }
let director5 = { Name = "Denis Villeneuve"; Movies = 24 }
let director6 = { Name = "Reinaldo Marcus Green"; Movies = 15 }
let director7 = { Name = "Paul Thomas Anderson"; Movies = 49 }
let director8 = { Name = "Guillermo Del Toro"; Movies = 22 }

let movie1 = { Name = "CODA"; RunLength = 111; Genre = Drama; Director = director1; IMDBRating = 8.1 }
let movie2 = { Name = "Belfast"; RunLength = 98; Genre = Comedy; Director = director2; IMDBRating = 7.3 }
let movie3 = { Name = "Don't Look Up"; RunLength = 138; Genre = Comedy; Director = director3; IMDBRating = 7.2 }
let movie4 = { Name = "Drive My Car"; RunLength = 179; Genre = Drama; Director = director4; IMDBRating = 7.6 }
let movie5 = { Name = "Dune"; RunLength = 155; Genre = Fantasy; Director = director5; IMDBRating = 8.1 }
let movie6 = { Name = "King Richard"; RunLength = 144; Genre = Sport; Director = director6; IMDBRating = 7.5 }
let movie7 = { Name = "Licorice Pizza"; RunLength = 133; Genre = Comedy; Director = director7; IMDBRating = 7.4 }
let movie8 = { Name = "Nightmare Alley"; RunLength = 150; Genre = Thriller; Director = director8; IMDBRating = 7.1 }

let movies = [ movie1; movie2; movie3; movie4; movie5; movie6; movie7; movie8 ]

let probableOscarWinners movies =
    movies |> List.filter (fun movie -> movie.IMDBRating > 7.4)

let oscarWinners = probableOscarWinners movies

let convertRunLengthToHoursMinutes runLength =
    let hours = runLength / 60
    let minutes = runLength % 60
    sprintf "%dh %dmin" hours minutes

let convertMoviesRunLength movies =
    movies |> List.map (fun movie -> convertRunLengthToHoursMinutes movie.RunLength)

let runLengthsInHoursMinutes = convertMoviesRunLength movies

printfn "Probable Oscar Winners:"
oscarWinners |> List.iter (fun movie -> printfn "%s (IMDB Rating: %.1f)" movie.Name movie.IMDBRating)

printfn "\nMovie Run Lengths in Hours and Minutes:"
runLengthsInHoursMinutes |> List.iter (fun length -> printfn "%s" length)
