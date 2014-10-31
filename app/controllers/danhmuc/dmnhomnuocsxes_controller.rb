module Danhmuc
  class DmnhomnuocsxesController < PageController
    respond_to :html, :js

    def index
      @dmnhomnuocsxes = Dmnhomnuocsx.all
    end

    def show
      @dmnhomnuocsx = Dmnhomnuocsx.find(params[:id])
    end

    def edit
      @dmnhomnuocsx = Dmnhomnuocsx.find(params[:id])
    end

    def update
      @dmnhomnuocsxes = Dmnhomnuocsx.all
      @dmnhomnuocsx = Dmnhomnuocsx.find(params[:id])

      @dmnhomnuocsx.update_attributes(dmnhomnuocsx_params)
    end

    def new
      @dmnhomnuocsx = Dmnhomnuocsx.new
    end

    def create
      @dmnhomnuocsxes = Dmnhomnuocsx.all
      @dmnhomnuocsx = Dmnhomnuocsx.create(dmnhomnuocsx_params)
    end

    def delete
      @dmnhomnuocsx = Dmnhomnuocsx.find(params[:dmnhomnuocsx_id])
    end

    def destroy
      @dmnhomnuocsxes = Dmnhomnuocsx.all
      @dmnhomnuocsx = Dmnhomnuocsx.find(params[:id])
      @dmnhomnuocsx.destroy
    end

    private
    def dmnhomnuocsx_params
      params.require(:dmnhomnuocsx).permit(:stt, :ten)
    end
  end
end