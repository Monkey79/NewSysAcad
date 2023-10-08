docker rm $(docker ps -a -q)
docker rmi $(docker images -q)
docker volume rm -f $(docker volume ls -f dangling=true -q)

docker build -t mysqlacad_img:v1 .
docker run -d --name mysqlacadcont -p 3306:3306 mysqlacad_img:v1
docker exec -it mysqlacadcont mysql -u root -p
    show databases;
    use sysacad_db;
    show tables;