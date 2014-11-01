json.array!(@dmlydohoantras) do |dmlydohoantra|
  json.extract! dmlydohoantra, :id, :stt, :ten
  json.url dmlydohoantra_url(dmlydohoantra, format: :json)
end
