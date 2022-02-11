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
                
                withAWS(credentials: 'aws-credentials', region: 'eu-central-1') {
                    sh 'echo "hello KB">hello.txt'
                    s3Upload acl: 'Private', bucket: '555256523315.dkr.ecr.eu-central-1.amazonaws.com/ivaylo_petrov', file: 'ivaylo_petrov'
                }
                
                sh "docker push 555256523315.dkr.ecr.eu-central-1.amazonaws.com/ivaylo_petrov:latest"
            }
        }
    }
}





