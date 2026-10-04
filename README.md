# MicroBlog

## Project Description

MicroBlog is an ASP.NET Core Razor Pages application that allows users to create and view blog posts.

The application uses the Repository Pattern and Dependency Injection to separate data storage from the rest of the application.

The application can use either a JSON file or an in-memory list to store blog posts.

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
- Repository Pattern for separating data storage from the application.
- Dependency Injection for providing the repository to Razor Pages.
- Ability to switch between JSON and in-memory data storage.

## Technologies Used

- C#
- ASP.NET Core Razor Pages
- .NET 10
- HTML
- CSS
- Bootstrap
- JSON
- Dependency Injection
- Repository Pattern

## Project Structure

```text
MicroBlog/
├── Models/
│   └── Post.cs
├── Repositories/
│   ├── IBlogRepository.cs
│   ├── InMemoryBlogRepository.cs
│   └── JsonBlogRepository.cs
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


##PHOTOS
<img width="317" height="529" alt="image" src="https://github.com/user-attachments/assets/c23834a2-ce71-404b-be82-9731cae9891d" />


