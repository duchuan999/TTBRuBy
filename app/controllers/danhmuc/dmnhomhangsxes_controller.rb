module Danhmuc
  class DmnhomhangsxesController < PageController
    respond_to :html, :js

    def index
      @dmnhomhangsxes = Dmnhomhangsx.all
    end

    def show
      @dmnhomhangsx = Dmnhomhangsx.find(params[:id])
    end

    def edit
      @dmnhomhangsx = Dmnhomhangsx.find(params[:id])
    end

    def update
      @dmnhomhangsxes = Dmnhomhangsx.all
      @dmnhomhangsx = Dmnhomhangsx.find(params[:id])

      @dmnhomhangsx.update_attributes(dmnhomhangsx_params)
    end

    def new
      @dmnhomhangsx = Dmnhomhangsx.new
    end

    def create
      @dmnhomhangsxes = Dmnhomhangsx.all
      @dmnhomhangsx = Dmnhomhangsx.create(dmnhomhangsx_params)
    end

    def delete
      @dmnhomhangsx = Dmnhomhangsx.find(params[:dmnhomhangsx_id])
    end

    def destroy
      @dmnhomhangsxes = Dmnhomhangsx.all
      @dmnhomhangsx = Dmnhomhangsx.find(params[:id])
      @dmnhomhangsx.destroy
    end

    private
    def dmnhomhangsx_params
      params.require(:dmnhomhangsx).permit(:stt, :ten)
    end
  end
end