
# MicroBlog

## Project Description

MicroBlog is an ASP.NET Core Razor Pages application that allows users to create and view blog posts.

The application uses a JSON file to store posts so that data persists when the application is restarted.

## Features

- View all blog posts on the home page.
- Create new blog posts with a title and body.
- View individual posts on a Details page.
- Automatically assign a unique ID to each post.
- Automatically record the UTC creation date and time.
- Validate required fields using data annotations.
- Save and load posts using JSON serialization.
- Reusable partial view for displaying post summaries.
- Shared layout with navigation bar.

## Technologies Used

- C#
- ASP.NET Core Razor Pages
- .NET 10
- HTML
- CSS
- Bootstrap
- JSON

## Project Structure

```text
MicroBlog/
├── Models/
│   └── Post.cs
├── Services/
│   └── PostService.cs
├── Pages/
│   ├── Index.cshtml
│   ├── Index.cshtml.cs
│   ├── Create.cshtml
│   ├── Create.cshtml.cs
│   ├── Details.cshtml
│   ├── Details.cshtml.cs
│   ├── Shared/
│   │   ├── _Layout.cshtml
│   │   └── _PostCard.cshtml
│   └── _ViewImports.cshtml
├── data/
│   └── posts.json
├── wwwroot/
├── Program.cs
└── README.md
```

## Pages

| Page | Description |
|---|---|
| Index | Displays all blog posts. |
| Create | Provides a form to create a new post. |
| Details | Displays the full content of a selected post. |

## Data Storage

Blog posts are stored in `data/posts.json`.

Each post contains:

- Id: Unique identifier for the post.
- Title: Title of the blog post.
- Body: Content of the blog post.
- CreatedUtc: Date and time the post was created in UTC.

The application loads existing posts when the service starts and saves new posts to the JSON file.

## How to Run

1. Clone or download the repository.
2. Open the MicroBlog solution in Visual Studio.
3. Restore NuGet packages if needed.
4. Build the solution.
5. Run the application using Ctrl + F5.

The application will automatically create the data folder and JSON file if they do not exist.

## Author

Mikaela Fischer

## Photos 
<img width="294" height="302" alt="image" src="https://github.com/user-attachments/assets/d8534462-42e2-43a0-a26d-409c6963f2f0" />
<img width="273" height="378" alt="image" src="https://github.com/user-attachments/assets/686ec983-c360-4194-93e7-7e0ab972da5d" />
<img width="680" height="195" alt="image" src="https://github.com/user-attachments/assets/adaa205c-e832-4a12-8641-6854861addfa" />


