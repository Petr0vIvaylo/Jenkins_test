pipeline {
    agent any 
        
    triggers {
        githubPush()
    }
    
    stages{
        stage('Build') {
            steps {
                sh "echo 'build started'"
               
            }
        }
        
        
        stage(SonarQube_analysis) {
            steps {
                withSonarQubeEnv('SonarQube'){
                    sh "dotnet build AnimalFarm.csproj"
                    sh "../../../sonar-scanner-2.9.0.670/bin/sonar-scanner" 
                }
            }    
        }
        
        stage("Quality gate") {
            steps {
                waitForQualityGate abortPipeline: true
            }
        }
    }
}
