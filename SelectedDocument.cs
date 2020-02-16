namespace testApp
{
    public struct SelectedDocument
    {
        public string id;
        public string date;
        public string description;
        public string status;
        public string signed;
        public SelectedDocument(
            string documentId, string documentDate, 
            string documentDescription, string documnetStatus, 
            string documentSigned)
        {
            id = documentId;
            date = documentDate;
            description = documentDescription;
            status = documnetStatus;
            signed = documentSigned;
        }
    }
}