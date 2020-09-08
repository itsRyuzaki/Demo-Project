pipeline{
    agent any
    stages{
        stage('Git-Checkout'){
            steps{
                echo "Checking out from git repo";
                url:"https://github.com/itsRyuzaki/Demo-Project.git"
            }
        }
        stage('Build'){
            steps{
                echo "Building the project";
                dotnet build;
	        	
            }
        }
         stage('Unit-Tests'){
            steps{
                echo "Running Junit-Tests";
                dotnet test test-library/test-library.csproj;
		
            }
        }
        
    }
}