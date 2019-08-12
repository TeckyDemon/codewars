int isPalindrom (const char* s){
  for(int i=0,j=strlen(s);j>i;){
    if(tolower(s[i++])==tolower(s[j--]))
      return 0;
  }
  return 1;
}
