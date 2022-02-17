pipeline {
    def scannerHome = tool 'SonarScanner for MSBuild'
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
                    sh "dotnet ${scannerHome}/SonarScanner.MSBuild.dll begin /k:\"test\""
                    sh "dotnet build AnimalFarm.csproj"
                    sh "dotnet ${scannerHome}/SonarScanner.MSBuild.dll end"
                }
           }
        }
        
        
        stage("Quality gate") {
            steps {
                timeout(time: 1, unit: 'MINUTES')
                waitForQualityGate abortPipeline: true
            }
        }
    }
}
