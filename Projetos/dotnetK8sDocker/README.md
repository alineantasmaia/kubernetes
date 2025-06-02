# dotnet-k8s-docker-app

This project is a .NET application designed to run in a containerized environment using Docker and orchestrated with Kubernetes. It consists of multiple services, including an API service and two microservices (Service A and Service B), along with a shared library for common models.

## Project Structure

```
dotnet-k8s-docker-app
├── src
│   ├── Api                # API service project
│   ├── Services           # Microservices
│   │   ├── ServiceA      # Service A project
│   │   └── ServiceB      # Service B project
│   └── Shared             # Shared library for common models
├── docker-compose.yml     # Docker Compose configuration
├── k8s                   # Kubernetes configuration files
│   ├── api-deployment.yaml
│   ├── servicea-deployment.yaml
│   ├── serviceb-deployment.yaml
│   └── namespace.yaml
├── .dockerignore          # Files to ignore in Docker builds
├── .gitignore             # Files to ignore in Git
├── README.md              # Project documentation
└── Directory.Build.props   # Common properties for all projects
```

## Getting Started

### Prerequisites

- .NET SDK
- Docker
- Kubernetes (Minikube, AKS, EKS, etc.)

### Setup

1. Clone the repository:
   ```
   git clone <repository-url>
   cd dotnet-k8s-docker-app
   ```

2. Build the Docker images:
   ```
   docker-compose build
   ```

3. Run the application locally using Docker Compose:
   ```
   docker-compose up
   ```

4. Deploy to Kubernetes:
   - Create the namespace:
     ```
     kubectl apply -f k8s/namespace.yaml
     ```
   - Deploy the services:
     ```
     kubectl apply -f k8s/api-deployment.yaml
     kubectl apply -f k8s/servicea-deployment.yaml
     kubectl apply -f k8s/serviceb-deployment.yaml
     ```

### Usage

- Access the API service at `http://localhost:<api-port>`
- Access Service A and Service B through their respective endpoints.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any enhancements or bug fixes.

## License

This project is licensed under the MIT License. See the LICENSE file for more details.