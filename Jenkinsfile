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
                    def scannerHome = tool 'SonarScanner for MSBuild'
                    sh "dotnet ${scannerHome}/SonarScanner.MSBuild.dll begin /k:\"test\""
                    sh "dotnet build AnimalFarm.csproj"
                    sh "dotnet ${scannerHome}/SonarScanner.MSBuild.dll end"
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
