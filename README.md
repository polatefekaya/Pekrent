# Pekrent

Welcome to **Pekrent**, a peer-to-peer car rental platform designed to revolutionize car sharing! Whether you're looking to rent a car from someone in your neighborhood or share your vehicle for some extra income, Pekrent makes it easy and efficient. Built with modern technologies, this project aims to provide a seamless user experience for both car owners and renters.

## Tech Stack

### Client Side
- **Language**: TypeScript
- **Framework**: Next.js
- **State Management**: Zustand
- **UI Library**: Chakra UI

The client side of Pekrent is implemented using **Next.js**, a popular React-based framework that provides server-side rendering (SSR), fast performance, and an improved development experience. TypeScript is used throughout for type safety and enhanced code maintainability. **Zustand** is used for state management, providing a simple and scalable approach to manage global state within the client application. **Chakra UI** is utilized to ensure a modern and responsive design with pre-built accessible components.

### Server Side
- **Language**: C#
- **Framework**: .NET Core 8
- **Database**: PostgreSQL with PostGIS for geolocation calculations
- **ORM**: Entity Framework Core
- **Monitoring and Security**: Azure Application Insights, Azure Key Vault, and Azure Pipelines

The backend is built with **.NET Core 8**, a high-performance, cross-platform framework that ensures robust API handling, security, and scalability. The server manages user authentication, rental transactions, payment processing, and other core functionalities. **PostgreSQL** is used as the primary database, with **PostGIS** extensions for geolocation calculations, enabling advanced location-based features. **Entity Framework Core** is used as the Object-Relational Mapper (ORM) to facilitate data access and manipulation, providing a seamless way to interact with PostgreSQL. The backend also integrates with **Azure Application Insights** for monitoring and logging, **Azure Key Vault** for secure management of secrets, and **Azure Pipelines** for continuous integration and deployment.

## Features
- **Peer-to-Peer Car Rentals**: Connect car owners with renters, enabling cost-effective and flexible rental options.
- **Next.js Client**: Fast and SEO-friendly front-end with server-side rendering.
- **Robust Backend**: High-performance backend to manage rental agreements, car listings, and user authentication.
- **Geolocation Features**: Advanced geolocation calculations powered by PostGIS to find cars near you.
- **Secure Payment Handling**: Integrates secure payment gateways to ensure a smooth transaction process.
- **Type Safety**: TypeScript and C# for end-to-end type safety, reducing runtime errors and ensuring consistent data handling.
- **Database Management**: Efficient data access using Entity Framework Core to interact with PostgreSQL.
- **State Management**: Client-side state management with Zustand for a scalable and efficient data flow.
- **UI/UX**: Responsive and accessible UI components using Chakra UI.
- **Monitoring and Insights**: Azure Application Insights integration for real-time monitoring and diagnostics.
- **Secret Management**: Secure storage and retrieval of secrets using Azure Key Vault.
- **CI/CD**: Azure Pipelines for continuous integration and delivery, ensuring fast and reliable deployments.

## Getting Started

### Prerequisites
- **Node.js** (v16+)
- **.NET Core SDK** (v8.0)
- **PostgreSQL** (v12+ with PostGIS)
- **NPM/Yarn** for package management

### Installation
1. **Clone the Repository**:
   ```bash
   git clone https://github.com/polatefekaya/Pekrent.git
   cd Pekrent
   ```

2. **Client Setup**:
   - Navigate to the `client` folder:
     ```bash
     cd client
     ```
   - Install dependencies:
     ```bash
     npm install
     ```
   - Start the development server:
     ```bash
     npm run dev
     ```
   
3. **Server Setup**:
   - Navigate to the `server` folder:
     ```bash
     cd ../server
     ```
   - Restore .NET dependencies:
     ```bash
     dotnet restore
     ```
   - Set up the database connection in the `.env` file.
   - Apply Entity Framework Core migrations to set up the database:
     ```bash
     dotnet ef database update
     ```
   - Run the backend server:
     ```bash
     dotnet run
     ```

### Running the Application
- The client side should be accessible at `http://localhost:3000`
- The backend API runs by default at `http://localhost:5000`

### Environment Variables
Create a `.env` file in both the `client` and `server` directories to set up required environment variables such as database connection strings, API keys, Azure credentials, etc.

## Folder Structure
- **client/**: Contains the Next.js application.
- **server/**: Contains the .NET Core API for handling car rentals.
- **docs/**: Documentation regarding API, architecture, and design choices.

## Contributing
We welcome contributions! To get started:
1. Fork the repository.
2. Create a new branch (`git checkout -b feature/YourFeatureName`).
3. Commit your changes (`git commit -m 'Add your feature'`).
4. Push to the branch (`git push origin feature/YourFeatureName`).
5. Open a pull request.

## Contact
If you have any questions, suggestions, or feedback, feel free to reach out:
- GitHub: [polatefekaya](https://github.com/polatefekaya)

Thank you for checking out **Pekrent**! I hope you find it useful and exciting to contribute to.

