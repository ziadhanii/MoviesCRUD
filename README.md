# Movies CRUD MVC Application

A full-featured ASP.NET Core MVC application for managing a movie database with complete CRUD (Create, Read, Update, Delete) operations.

## 🎬 Features

- **Movie Management**: Add, view, edit, and delete movies
- **Genre Management**: Organize movies by genres
- **Image Upload**: Upload and manage movie posters with validation
- **Responsive Design**: Bootstrap-based responsive UI
- **Toast Notifications**: User-friendly notifications for actions
- **Data Validation**: Server-side and client-side validation
- **Entity Framework**: Code-First approach with SQL Server

## 🛠️ Technologies Used

- **Backend**: ASP.NET Core 9.0 MVC
- **Database**: SQL Server with Entity Framework Core 9.0
- **Frontend**: HTML5, CSS3, Bootstrap, jQuery
- **Notifications**: NToastNotify (Toastr)
- **File Upload**: Custom file validation attributes
- **Icons**: Bootstrap Icons
- **Animations**: Animate.css

## 📋 Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (LocalDB or full version)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

## 🚀 Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/ziadhanii/movies-crud-mvc.git
cd movies-crud-mvc
```

### 2. Update Connection String

Update the connection string in `appsettings.json` to match your SQL Server configuration:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=.;Initial catalog=Movies;Integrated Security=true;TrustServerCertificate=true"
  }
}
```

### 3. Install Dependencies

```bash
dotnet restore
```

### 4. Create and Update Database

```bash
dotnet ef database update
```

### 5. Run the Application

```bash
dotnet run
```

The application will be available at `https://localhost:5001` or `http://localhost:5000`.

## 📁 Project Structure

```text
Movies/
├── Controllers/          # MVC Controllers
│   ├── HomeController.cs
│   └── MoviesController.cs
├── Models/              # Data models
│   ├── Movie.cs
│   ├── Genre.cs
│   └── ErrorViewModel.cs
├── Views/               # Razor views
│   ├── Home/
│   ├── Movies/
│   └── Shared/
├── ViewModels/          # View models
│   ├── MovieFormViewModel.cs
│   ├── CreateFormViewModel.cs
│   └── EditFormViewModel.cs
├── Services/            # Business logic services
│   ├── IMoviesService.cs
│   ├── MoviesService.cs
│   ├── IGenresService.cs
│   └── GenresService.cs
├── Data/                # Entity Framework context
│   └── MoviesDbContext.cs
├── Migrations/          # EF Core migrations
├── Attributes/          # Custom validation attributes
│   ├── AllowedExtensions.cs
│   └── MaxFileSize.cs
├── Settings/            # Configuration settings
│   └── FileSettings.cs
└── wwwroot/            # Static files (CSS, JS, images)
```

## 🎯 Key Features Explained

### Movie Model

- **Title**: Movie title (required, max 255 characters)
- **Year**: Release year
- **Rate**: Movie rating
- **StoryLine**: Movie description (required, max 2500 characters)
- **Poster**: Image file path (required, max 500 characters)
- **Genre**: Associated genre (foreign key relationship)

### Custom Validation Attributes

- **AllowedExtensions**: Validates file extensions for uploaded images
- **MaxFileSize**: Ensures uploaded files don't exceed size limits

### Services Layer

- **IMoviesService/MoviesService**: Handles movie-related business logic
- **IGenresService/GenresService**: Manages genre operations

## 🎨 UI Features

- **Responsive Design**: Mobile-friendly interface using Bootstrap
- **Toast Notifications**: Success/error messages using NToastNotify
- **Image Validation**: Client-side and server-side image validation
- **Smooth Animations**: Enhanced user experience with Animate.css
- **DatePicker**: Bootstrap DatePicker for date inputs
- **SweetAlert2**: Enhanced alert dialogs

## 🔧 Configuration

### File Upload Settings

Configure file upload limits and allowed extensions in `FileSettings.cs`.

### Database Configuration

The application uses Entity Framework Core with SQL Server. Connection strings are configured in `appsettings.json`.

### Toast Notifications

Toast notifications are configured in `Program.cs` with:

- Progress bar enabled
- Top-right positioning
- Duplicate prevention
- Close button

## 📸 Screenshots

<!-- Add screenshots of your application here -->

## 🤝 Contributing

1. Fork the project
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 👨‍💻 Author

### Ziad Hani

- GitHub: [@ziadhanii](https://github.com/ziadhanii)

## 🙏 Acknowledgments

- ASP.NET Core team for the amazing framework
- Bootstrap team for the responsive CSS framework
- All contributors to the open-source libraries used in this project

---

⭐ Star this repository if you find it helpful!
