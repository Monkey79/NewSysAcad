FROM mysql:latest

ENV MYSQL_ROOT_PASSWORD=root
ENV MYSQL_DATABASE=sysacad_db

##INIT DB##
COPY 01-schema.sql /docker-entrypoint-initdb.d/
COPY 02-data.sql /docker-entrypoint-initdb.d/

##EXPOSE##
EXPOSE 3306

##VOLUME##
VOLUME ['/var/lib/mysql']
