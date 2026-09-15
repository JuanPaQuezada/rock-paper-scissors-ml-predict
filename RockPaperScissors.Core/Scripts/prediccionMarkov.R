args<-commandArgs(trailingOnly=TRUE)
if(length(args)==0){
    stop("Error, formato incorrecto")
}
cadena<-strsplit(args[1],",\\s*")
vector<-as.numeric(unlist(cadena))

matriz_laplace<-matrix(nrow=3,ncol=3)
matriz_laplace[]<-1

for(i in 1:(length(vector)-1)){
    matriz_laplace[vector[i],vector[i+1]]<-matriz_laplace[vector[i],vector[i+1]]+1
}

indice_frecuencia_alta=which.max(matriz_laplace[vector[length(vector)],])
if(indice_frecuencia_alta==1){
    contra_movimiento<-2
}else if(indice_frecuencia_alta==2){
    contra_movimiento<-3
}else{
    contra_movimiento<-1
}

cat(contra_movimiento)
