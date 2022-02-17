pipeline {
    agent any 
        
    triggers {
        githubPush()
    }
    
    node {
  stage('SCM') {
    checkout scm
  }
  stage('SonarQube Analysis') {
    def scannerHome = tool 'SonarScanner for MSBuild'
    withSonarQubeEnv() {
      sh "dotnet ${scannerHome}/SonarScanner.MSBuild.dll begin /k:\"test\""
      sh "dotnet build"
      sh "dotnet ${scannerHome}/SonarScanner.MSBuild.dll end"
    }
  }
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
                    sh "dotnet tool install --global dotnet-sonarscanner"
                    sh "dotnet sonarscanner begin -k:"test" -d:sonar.login="sonarQube""
                    sh "dotnet build AnimalFarm.csproj"
                    sh "dotnet sonarscanner end /d:sonar.login="sonarQube""
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
