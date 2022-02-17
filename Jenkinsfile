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
