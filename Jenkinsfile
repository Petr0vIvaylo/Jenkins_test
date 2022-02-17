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
                   stage('SonarQube Analysis') {
                     def scannerHome = tool 'SonarScanner for MSBuild'
                     withSonarQubeEnv() {
                        sh "dotnet ${scannerHome}/SonarScanner.MSBuild.dll begin /k:\"test\""
                        sh "dotnet build"
                        sh "dotnet ${scannerHome}/SonarScanner.MSBuild.dll end"
                     }
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
