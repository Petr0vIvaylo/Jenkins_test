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
                withSonarQubeEnv('sonarqube'){
                sh "dotnet build AnimalFarm.csproj"
                sh "./gradlew sonarqube"
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
