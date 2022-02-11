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
                docker tag ivaylo_petrov:latest 555256523315.dkr.ecr.eu-central-1.amazonaws.com/ivaylo_petrov:latest
            }
        }

        stage('Push') {
            steps {
                sh "echo 'pushing..'"
                docker push 555256523315.dkr.ecr.eu-central-1.amazonaws.com/ivaylo_petrov:latest
            }
        }
    }
}





