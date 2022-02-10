pipeline {
    agent any 
        
    triggers {
        githubPush()
    }

    stage('Build') {
        steps {
            sh(script: echo 'build started') 
            sh(script: 'docker build -t ipetrov84/education:dev . ')
        }
    }

    stage('push') {
        steps {
            sh(script: echo 'pushing..')
            sh(script: docker push ipetrov84/education:dev)
            sh(script: echo 'end')
        }
    }

}





