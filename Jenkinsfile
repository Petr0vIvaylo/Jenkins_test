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
                sh "echo 'pushing..'"
                sh $(aws ecr get-login --no-include-email --region eu-central-1)
                sh "docker push 555256523315.dkr.ecr.eu-central-1.amazonaws.com/ivaylo_petrov:latest"
            }
        }
    }
}





