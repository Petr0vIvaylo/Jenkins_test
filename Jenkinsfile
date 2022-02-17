    
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
                withSonarQubeEnv(SonarScanner){
                    sh "dotnet build AnimalFarm.csproj"
                }
           }
        }
        
        
        stage("Quality gate") {
            steps {
                timeout(time: 1, unit: 'MINUTES') {
                    waitForQualityGate abortPipeline: true
                }
            }
        }
    }
}
