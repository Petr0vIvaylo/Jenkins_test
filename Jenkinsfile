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
                sh "docker images"
            }
        }

        stage('Push') {
            steps {
                withAWS(credentials: 'aws-credentials', region: 'eu-central-1') {
                    s3Upload(acl: 'Private', bucket: '555256523315.dkr.ecr.eu-central-1.amazonaws.com/ivaylo_petrov', file: 'ivaylo_petrov')
                }
            }
        }
    }
}





