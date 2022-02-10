pipeline {
    agent any 
        
    triggers {
        githubPush()
    }

    stage('Build') {
        steps {
            sh""
                echo 'build started'
                docker build -t ipetrov84/education:dev . 
              ""
        }
    }

    stage('push') {
        steps {
            sh "echo 'pushing..'"
            sh "docker push ipetrov84/education:dev"
            sh "echo 'end'"
        }
    }

}





