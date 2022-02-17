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
                withSonarQubeEnv(installationName: 'SonarQube'){
                     "dotnet tool install --global dotnet-sonarscanner"
                     "dotnet sonarscanner begin -k:"test" -d:sonar.login="sonarQube""
                     "dotnet build AnimalFarm.csproj"
                     "dotnet sonarscanner end /d:sonar.login="sonarQube""
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
