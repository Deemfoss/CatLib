FROM microsoft/dotnet:latest
COPY . /CatLib
WORKDIR /CatLib
EXPOSE 5000/tcp
ENV ASPNETCORE https://+:5000
ENTRYPOINT [ "executable" ]