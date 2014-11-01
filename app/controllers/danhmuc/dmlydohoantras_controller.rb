module Danhmuc
  class DmlydohoantrasController < PageController

    respond_to :html, :js

    def index
      @dmlydohoantras = Dmlydohoantra.all
    end

    def show
      @dmlydohoantra = Dmlydohoantra.find(params[:id])
    end

    def edit
      @dmlydohoantra = Dmlydohoantra.find(params[:id])
    end

    def update
      @dmlydohoantras = Dmlydohoantra.all
      @dmlydohoantra = Dmlydohoantra.find(params[:id])

      @dmlydohoantra.update_attributes(dmlydohoantra_params)
    end

    def new
      @dmlydohoantra = Dmlydohoantra.new
    end

    def create
      @dmlydohoantras = Dmlydohoantra.all
      @dmlydohoantra = Dmlydohoantra.create(dmlydohoantra_params)
    end

    def delete
      @dmlydohoantra = Dmlydohoantra.find(params[:dmlydohoantra_id])
    end

    def destroy
      @dmlydohoantras = Dmlydohoantra.all
      @dmlydohoantra = Dmlydohoantra.find(params[:id])
      @dmlydohoantra.destroy
    end

    private
    def dmlydohoantra_params
      params.require(:dmlydohoantra).permit(:stt, :ten)
    end

  end
end