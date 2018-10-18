#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY ["CalcApi.csproj", "CalcApi/"]
RUN dotnet restore "CalcApi/CalcApi.csproj"
COPY . .
WORKDIR "/src/CalcApi"
RUN dotnet build "CalcApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CalcApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CalcApi.dll"]

#FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1709
#COPY . /app
#WORKDIR /app
#RUN ["dotnet","restore"]
#RUN ["dotnet","build"]
#EXPOSE 5000/tcp
#ENTRYPOINT ["dotnet","run","--server.urls","http://0.0.0.0:5000"]