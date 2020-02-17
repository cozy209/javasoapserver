FROM openjdk:8
EXPOSE 9999
COPY . /usr/src/myapp
WORKDIR /usr/src/myapp
RUN javac Application.java
ENTRYPOINT ["java", "Application"]
