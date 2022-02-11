pipeline {
    agent any 
        
    triggers {
        githubPush()
    }
    
    stages{
        stage('Build') {
            steps {
                sh "echo 'build started'"
                sh "docker build -t ivaylo_petrov ."
                sh "docker tag ivaylo_petrov:latest 555256523315.dkr.ecr.eu-central-1.amazonaws.com/ivaylo_petrov:latest"
            }
        }

        stage('Push') {
            steps {
                sh "aws ecr get-login-password --region eu-central-1 | docker login --username AWS --password-stdin 555256523315.dkr.ecr.eu-central-1.amazonaws.com"
                sh "docker push 555256523315.dkr.ecr.eu-central-1.amazonaws.com/ivaylo_petrov:latest"
                }
            }
        
    }
}





