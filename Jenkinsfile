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
                sh "docker push ipetrov84/education:dev"
                
                }
           
        }
    }
}
