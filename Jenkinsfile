pipeline{
    agent any
    stages{
        stage('Git-Checkout'){
            steps{
                echo "Checking out from git repo";
                git url:"https://github.com/itsRyuzaki/Demo-Project.git"
            }
        }
        stage('Restore-packages'){
            steps{
                echo "Preprocessing: Restore packages";
                bat "dotnet restore"
            }
        }
        stage('Build'){
            steps{
                echo "Building the project";
                bat "dotnet build";
	        	
            }
        }
         stage('Unit-Tests'){
            steps{
                echo "Running Junit-Tests";
                bat "dotnet test test-library/test-library.csproj";
		
            }
        }
        
    }
}