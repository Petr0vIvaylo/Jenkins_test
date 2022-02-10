pipeline {
    agent any 
        
    triggers {
        githubPush()
    }
    stages{
        stage('Build') {
            steps {
                sh "echo 'build started'"
                sh "docker build -t ipetrov84/education:dev ."
            }
        }

        stage('Push') {
            steps {
                sh "echo 'pushing..'"
                sh "docker push ipetrov84/education:dev"
                sh "echo 'end'"
            }
        }
    }
}





