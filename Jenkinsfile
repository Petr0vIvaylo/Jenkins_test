pipeline {
    agent any 
        
    triggers {
        githubPush()
    }
    
    stages{
        stage('Build') {
            steps {
                sh "echo 'build started'"
                sh "docker build -t ivaylo_petrov -f Dockerfile ."
            }
        }
        
        stage('Push') {
            steps {
                
             }
        }
        
        stage(SonarQube_analysis) {
            steps {
                withSonarQubeEnv('SonarQube'){
                sh "./MSBuild sonarqube"
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
